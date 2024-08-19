using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Text.Json;


namespace LocalizationDecoupler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void OpenIniFileDialog()
        {
            string SelectedIniFile = "";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "INI файлы (*.ini)|*.ini|Все файлы (*.*)|*.*";
            openFileDialog1.Title = "Выберите INI файл";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SelectedIniFile = openFileDialog1.FileName;
            }

            guna2TextBox1.Text = SelectedIniFile;
        }
        private void ViewButton_Click(object sender, EventArgs e)
        {
            OpenIniFileDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DecoupleButton_Click(object sender, EventArgs e)
        {
            string text = guna2TextBox1.Text;
            string translate = "";
            string ID = "";
            Dictionary<string, string> data = new Dictionary<string, string>();
            StreamReader streamReader = new StreamReader(text);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();                
                if (line.Contains("="))
                {
                    if (translate != "")
                    {
                        data.Add(ID, translate);
                    }
                    ID = line.Substring(0, line.IndexOf('='));
                    translate = line.Substring(line.IndexOf('=') + 1, line.Length - line.IndexOf('=')-1);
                }
                else
                {
                    translate += line + "\n";
                }
            }           
            string JSON = JsonSerializer.Serialize(data);
            JSON = System.Text.RegularExpressions.Regex.Unescape(JSON);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON файлы (*.json)|*.json|Все файлы (*.*)|*.*";
            saveFileDialog.Title = "Сохранить JSON файл";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, JSON);               
            }
        }
    }
}
