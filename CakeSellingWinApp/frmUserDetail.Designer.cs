
namespace CakeSellingWinApp
{
    partial class frmUserDetail
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
            this.lbStatusInformation = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbRoleInformation = new System.Windows.Forms.Label();
            this.lbStaff = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.pnExtraInfo = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gbUserInfo.SuspendLayout();
            this.pnExtraInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbStatusInformation
            // 
            this.lbStatusInformation.AutoSize = true;
            this.lbStatusInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatusInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbStatusInformation.Location = new System.Drawing.Point(501, 22);
            this.lbStatusInformation.Name = "lbStatusInformation";
            this.lbStatusInformation.Size = new System.Drawing.Size(0, 15);
            this.lbStatusInformation.TabIndex = 2;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatus.Location = new System.Drawing.Point(416, 22);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(39, 15);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status";
            // 
            // lbRoleInformation
            // 
            this.lbRoleInformation.AutoSize = true;
            this.lbRoleInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRoleInformation.Location = new System.Drawing.Point(108, 22);
            this.lbRoleInformation.Name = "lbRoleInformation";
            this.lbRoleInformation.Size = new System.Drawing.Size(0, 15);
            this.lbRoleInformation.TabIndex = 1;
            this.lbRoleInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStaff
            // 
            this.lbStaff.AutoSize = true;
            this.lbStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStaff.Location = new System.Drawing.Point(14, 22);
            this.lbStaff.Name = "lbStaff";
            this.lbStaff.Size = new System.Drawing.Size(30, 15);
            this.lbStaff.TabIndex = 0;
            this.lbStaff.Text = "Role";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(567, 467);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyDown);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(679, 467);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.Location = new System.Drawing.Point(114, 185);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(214, 23);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhoneNumber.Location = new System.Drawing.Point(20, 190);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(88, 15);
            this.lbPhoneNumber.TabIndex = 0;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.Location = new System.Drawing.Point(507, 44);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(214, 23);
            this.txtFullName.TabIndex = 2;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFullName.Location = new System.Drawing.Point(422, 47);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(61, 15);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Full Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(507, 185);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 23);
            this.txtAddress.TabIndex = 6;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddress.Location = new System.Drawing.Point(422, 190);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(49, 15);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Address";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(507, 117);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(214, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(419, 120);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(114, 117);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(214, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(20, 120);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 15);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(114, 44);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(214, 23);
            this.txtUserName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(20, 50);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 15);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "UserName";
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.pnExtraInfo);
            this.gbUserInfo.Controls.Add(this.txtFullName);
            this.gbUserInfo.Controls.Add(this.lbFullName);
            this.gbUserInfo.Controls.Add(this.txtPassword);
            this.gbUserInfo.Controls.Add(this.lbPassword);
            this.gbUserInfo.Controls.Add(this.txtAddress);
            this.gbUserInfo.Controls.Add(this.lbAddress);
            this.gbUserInfo.Controls.Add(this.txtPhoneNumber);
            this.gbUserInfo.Controls.Add(this.lbPhoneNumber);
            this.gbUserInfo.Controls.Add(this.txtEmail);
            this.gbUserInfo.Controls.Add(this.txtUserName);
            this.gbUserInfo.Controls.Add(this.lbEmail);
            this.gbUserInfo.Controls.Add(this.lbName);
            this.gbUserInfo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbUserInfo.Location = new System.Drawing.Point(13, 81);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(749, 320);
            this.gbUserInfo.TabIndex = 16;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User\'s information";
            // 
            // pnExtraInfo
            // 
            this.pnExtraInfo.Controls.Add(this.lbStatusInformation);
            this.pnExtraInfo.Controls.Add(this.lbRoleInformation);
            this.pnExtraInfo.Controls.Add(this.lbStatus);
            this.pnExtraInfo.Controls.Add(this.lbStaff);
            this.pnExtraInfo.Location = new System.Drawing.Point(6, 246);
            this.pnExtraInfo.Name = "pnExtraInfo";
            this.pnExtraInfo.Size = new System.Drawing.Size(721, 54);
            this.pnExtraInfo.TabIndex = 7;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(355, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(60, 32);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Title";
            // 
            // frmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Detail";
            this.Load += new System.EventHandler(this.frmUserDetail_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.pnExtraInfo.ResumeLayout(false);
            this.pnExtraInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.Label lbStatusInformation;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbRoleInformation;
        private System.Windows.Forms.Label lbStaff;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnExtraInfo;
    }
}