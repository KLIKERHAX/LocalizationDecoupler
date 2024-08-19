namespace LocalizationDecoupler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            HeadPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            ExitButton = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ViewButton = new Guna.UI2.WinForms.Guna2Button();
            DecoupleButton = new Guna.UI2.WinForms.Guna2Button();
            HeadPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeadPanel
            // 
            HeadPanel.BorderColor = Color.Black;
            HeadPanel.BorderThickness = 2;
            HeadPanel.Controls.Add(ExitButton);
            HeadPanel.CustomizableEdges = customizableEdges2;
            HeadPanel.Dock = DockStyle.Top;
            HeadPanel.Location = new Point(0, 0);
            HeadPanel.Name = "HeadPanel";
            HeadPanel.ShadowDecoration.CustomizableEdges = customizableEdges3;
            HeadPanel.Size = new Size(800, 34);
            HeadPanel.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.CheckedState.ImageSize = new Size(25, 25);
            ExitButton.HoverState.ImageSize = new Size(25, 25);
            ExitButton.Image = Properties.Resources.cancel;
            ExitButton.ImageOffset = new Point(0, 0);
            ExitButton.ImageRotate = 0F;
            ExitButton.ImageSize = new Size(25, 25);
            ExitButton.Location = new Point(772, 5);
            ExitButton.Name = "ExitButton";
            ExitButton.PressedState.ImageSize = new Size(64, 64);
            ExitButton.ShadowDecoration.CustomizableEdges = customizableEdges1;
            ExitButton.Size = new Size(25, 25);
            ExitButton.TabIndex = 1;
            ExitButton.Click += ExitButton_Click;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = HeadPanel;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.CustomizableEdges = customizableEdges4;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(12, 40);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.ReadOnly = true;
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2TextBox1.Size = new Size(636, 36);
            guna2TextBox1.TabIndex = 1;
            // 
            // ViewButton
            // 
            ViewButton.CustomizableEdges = customizableEdges6;
            ViewButton.DisabledState.BorderColor = Color.DarkGray;
            ViewButton.DisabledState.CustomBorderColor = Color.DarkGray;
            ViewButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ViewButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ViewButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ViewButton.ForeColor = Color.White;
            ViewButton.Location = new Point(664, 40);
            ViewButton.Name = "ViewButton";
            ViewButton.ShadowDecoration.CustomizableEdges = customizableEdges7;
            ViewButton.Size = new Size(124, 36);
            ViewButton.TabIndex = 2;
            ViewButton.Text = "Обзор";
            ViewButton.Click += ViewButton_Click;
            // 
            // DecoupleButton
            // 
            DecoupleButton.CustomizableEdges = customizableEdges8;
            DecoupleButton.DisabledState.BorderColor = Color.DarkGray;
            DecoupleButton.DisabledState.CustomBorderColor = Color.DarkGray;
            DecoupleButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DecoupleButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DecoupleButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DecoupleButton.ForeColor = Color.White;
            DecoupleButton.Location = new Point(608, 98);
            DecoupleButton.Name = "DecoupleButton";
            DecoupleButton.ShadowDecoration.CustomizableEdges = customizableEdges9;
            DecoupleButton.Size = new Size(180, 45);
            DecoupleButton.TabIndex = 3;
            DecoupleButton.Text = "Разъединить";
            DecoupleButton.Click += DecoupleButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DecoupleButton);
            Controls.Add(ViewButton);
            Controls.Add(guna2TextBox1);
            Controls.Add(HeadPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            HeadPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel HeadPanel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ImageButton ExitButton;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button ViewButton;
        private Guna.UI2.WinForms.Guna2Button DecoupleButton;
    }
}
