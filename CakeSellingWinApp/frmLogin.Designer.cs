
namespace CakeSellingWinApp
{
    partial class frmLogin
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
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbIntroduction = new System.Windows.Forms.Label();
            this.lbWelcomeTitle = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lbLoginStatus = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbLoginTitle = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLogin.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panelUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelWelcome.Controls.Add(this.pictureBoxLogo);
            this.panelWelcome.Controls.Add(this.lbIntroduction);
            this.panelWelcome.Controls.Add(this.lbWelcomeTitle);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(382, 588);
            this.panelWelcome.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.BackgroundImage = global::CakeSellingWinApp.Properties.Resources.cake;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Location = new System.Drawing.Point(139, 16);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(114, 133);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lbIntroduction
            // 
            this.lbIntroduction.AutoSize = true;
            this.lbIntroduction.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIntroduction.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbIntroduction.Location = new System.Drawing.Point(288, 527);
            this.lbIntroduction.Name = "lbIntroduction";
            this.lbIntroduction.Size = new System.Drawing.Size(78, 38);
            this.lbIntroduction.TabIndex = 1;
            this.lbIntroduction.Text = "Develop By\r\nGroup 2";
            this.lbIntroduction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbWelcomeTitle
            // 
            this.lbWelcomeTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbWelcomeTitle.AutoSize = true;
            this.lbWelcomeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbWelcomeTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbWelcomeTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbWelcomeTitle.Location = new System.Drawing.Point(12, 240);
            this.lbWelcomeTitle.Name = "lbWelcomeTitle";
            this.lbWelcomeTitle.Size = new System.Drawing.Size(356, 100);
            this.lbWelcomeTitle.TabIndex = 0;
            this.lbWelcomeTitle.Text = "Welcome to\r\nSelling Cake System";
            this.lbWelcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lbLoginStatus);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.panelPassword);
            this.panelLogin.Controls.Add(this.panelUsername);
            this.panelLogin.Controls.Add(this.lbLoginTitle);
            this.panelLogin.Controls.Add(this.btnCloseApp);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogin.Location = new System.Drawing.Point(382, 0);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(560, 588);
            this.panelLogin.TabIndex = 1;
            // 
            // lbLoginStatus
            // 
            this.lbLoginStatus.AutoSize = true;
            this.lbLoginStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLoginStatus.ForeColor = System.Drawing.Color.Red;
            this.lbLoginStatus.Location = new System.Drawing.Point(75, 357);
            this.lbLoginStatus.Name = "lbLoginStatus";
            this.lbLoginStatus.Size = new System.Drawing.Size(0, 25);
            this.lbLoginStatus.TabIndex = 7;
            this.lbLoginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(30, 405);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(165, 56);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyDown);
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.SystemColors.Window;
            this.panelPassword.Controls.Add(this.lbPassword);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Location = new System.Drawing.Point(0, 280);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(560, 60);
            this.panelPassword.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(7, 12);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(122, 32);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(137, 12);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(417, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.SystemColors.Window;
            this.panelUsername.Controls.Add(this.lbUsername);
            this.panelUsername.Controls.Add(this.txtUsername);
            this.panelUsername.Location = new System.Drawing.Point(0, 213);
            this.panelUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(560, 60);
            this.panelUsername.TabIndex = 4;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(3, 12);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(128, 32);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(137, 15);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(417, 27);
            this.txtUsername.TabIndex = 1;
            // 
            // lbLoginTitle
            // 
            this.lbLoginTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLoginTitle.AutoSize = true;
            this.lbLoginTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbLoginTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbLoginTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbLoginTitle.Location = new System.Drawing.Point(30, 128);
            this.lbLoginTitle.Name = "lbLoginTitle";
            this.lbLoginTitle.Size = new System.Drawing.Size(384, 50);
            this.lbLoginTitle.TabIndex = 3;
            this.lbLoginTitle.Text = "Login to your account";
            this.lbLoginTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseApp.Location = new System.Drawing.Point(503, 0);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(57, 67);
            this.btnCloseApp.TabIndex = 4;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = true;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 588);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelUsername.ResumeLayout(false);
            this.panelUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label lbWelcomeTitle;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lbIntroduction;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnCloseApp;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Label lbLoginTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbLoginStatus;
    }
}