namespace ManagmentApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserEntrance_Click = new MaterialSkin.Controls.MaterialFlatButton();
            this.AdminEntrance_Click = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.UserNameTF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UserPasswordTF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UserNameL = new System.Windows.Forms.Label();
            this.UserPasswordL = new System.Windows.Forms.Label();
            this.logPanelButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // UserEntrance_Click
            // 
            this.UserEntrance_Click.AutoSize = true;
            this.UserEntrance_Click.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserEntrance_Click.Depth = 0;
            this.UserEntrance_Click.Location = new System.Drawing.Point(268, 194);
            this.UserEntrance_Click.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserEntrance_Click.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserEntrance_Click.Name = "UserEntrance_Click";
            this.UserEntrance_Click.Primary = false;
            this.UserEntrance_Click.Size = new System.Drawing.Size(55, 36);
            this.UserEntrance_Click.TabIndex = 4;
            this.UserEntrance_Click.Text = "Giriş";
            this.UserEntrance_Click.UseVisualStyleBackColor = true;
            this.UserEntrance_Click.Click += new System.EventHandler(this.UserEntrance_click);
            // 
            // AdminEntrance_Click
            // 
            this.AdminEntrance_Click.AutoSize = true;
            this.AdminEntrance_Click.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdminEntrance_Click.Depth = 0;
            this.AdminEntrance_Click.Location = new System.Drawing.Point(247, 301);
            this.AdminEntrance_Click.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AdminEntrance_Click.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminEntrance_Click.Name = "AdminEntrance_Click";
            this.AdminEntrance_Click.Primary = false;
            this.AdminEntrance_Click.Size = new System.Drawing.Size(119, 36);
            this.AdminEntrance_Click.TabIndex = 5;
            this.AdminEntrance_Click.Text = "Admin Girişi";
            this.AdminEntrance_Click.UseVisualStyleBackColor = true;
            this.AdminEntrance_Click.Click += new System.EventHandler(this.AdminEntrance_click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(224, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 24);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Kullanıcı Girişi";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserNameTF
            // 
            this.UserNameTF.Depth = 0;
            this.UserNameTF.Hint = "";
            this.UserNameTF.Location = new System.Drawing.Point(177, 97);
            this.UserNameTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserNameTF.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserNameTF.Name = "UserNameTF";
            this.UserNameTF.PasswordChar = '\0';
            this.UserNameTF.SelectedText = "";
            this.UserNameTF.SelectionLength = 0;
            this.UserNameTF.SelectionStart = 0;
            this.UserNameTF.Size = new System.Drawing.Size(237, 28);
            this.UserNameTF.TabIndex = 9;
            this.UserNameTF.UseSystemPasswordChar = false;
            // 
            // UserPasswordTF
            // 
            this.UserPasswordTF.Depth = 0;
            this.UserPasswordTF.Hint = "";
            this.UserPasswordTF.Location = new System.Drawing.Point(177, 158);
            this.UserPasswordTF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPasswordTF.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserPasswordTF.Name = "UserPasswordTF";
            this.UserPasswordTF.PasswordChar = '\0';
            this.UserPasswordTF.SelectedText = "";
            this.UserPasswordTF.SelectionLength = 0;
            this.UserPasswordTF.SelectionStart = 0;
            this.UserPasswordTF.Size = new System.Drawing.Size(237, 28);
            this.UserPasswordTF.TabIndex = 10;
            this.UserPasswordTF.UseSystemPasswordChar = false;
            // 
            // UserNameL
            // 
            this.UserNameL.AutoSize = true;
            this.UserNameL.Location = new System.Drawing.Point(177, 75);
            this.UserNameL.Name = "UserNameL";
            this.UserNameL.Size = new System.Drawing.Size(82, 16);
            this.UserNameL.TabIndex = 11;
            this.UserNameL.Text = "Kullanıcı Adı:";
            // 
            // UserPasswordL
            // 
            this.UserPasswordL.AutoSize = true;
            this.UserPasswordL.Location = new System.Drawing.Point(180, 132);
            this.UserPasswordL.Name = "UserPasswordL";
            this.UserPasswordL.Size = new System.Drawing.Size(37, 16);
            this.UserPasswordL.TabIndex = 12;
            this.UserPasswordL.Text = "Şifre:";
            // 
            // logPanelButton
            // 
            this.logPanelButton.AutoSize = true;
            this.logPanelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logPanelButton.Depth = 0;
            this.logPanelButton.Location = new System.Drawing.Point(247, 252);
            this.logPanelButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.logPanelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logPanelButton.Name = "logPanelButton";
            this.logPanelButton.Primary = false;
            this.logPanelButton.Size = new System.Drawing.Size(109, 36);
            this.logPanelButton.TabIndex = 13;
            this.logPanelButton.Text = "Log Paneli";
            this.logPanelButton.UseVisualStyleBackColor = true;
            this.logPanelButton.Click += new System.EventHandler(this.logPanelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(585, 395);
            this.Controls.Add(this.logPanelButton);
            this.Controls.Add(this.UserPasswordL);
            this.Controls.Add(this.UserNameL);
            this.Controls.Add(this.UserPasswordTF);
            this.Controls.Add(this.UserNameTF);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.AdminEntrance_Click);
            this.Controls.Add(this.UserEntrance_Click);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Başlangıç Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton UserEntrance_Click;
        private MaterialSkin.Controls.MaterialFlatButton AdminEntrance_Click;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserNameTF;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserPasswordTF;
        private System.Windows.Forms.Label UserNameL;
        private System.Windows.Forms.Label UserPasswordL;
        private MaterialSkin.Controls.MaterialFlatButton logPanelButton;
    }
}

