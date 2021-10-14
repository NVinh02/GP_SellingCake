
namespace MyStoreWinApp
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
            this.gbMemberDetail = new System.Windows.Forms.GroupBox();
            this.pnPhoneNumber = new System.Windows.Forms.Panel();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.pnActive = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFullName = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnAddress = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.pnRole = new System.Windows.Forms.Panel();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.lbRole = new System.Windows.Forms.Label();
            this.pnPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.pnEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.pnUserName = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.gbMemberDetail.SuspendLayout();
            this.pnPhoneNumber.SuspendLayout();
            this.pnActive.SuspendLayout();
            this.pnFullName.SuspendLayout();
            this.pnAddress.SuspendLayout();
            this.pnRole.SuspendLayout();
            this.pnPassword.SuspendLayout();
            this.pnEmail.SuspendLayout();
            this.pnUserName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMemberDetail
            // 
            this.gbMemberDetail.Controls.Add(this.pnPhoneNumber);
            this.gbMemberDetail.Controls.Add(this.pnActive);
            this.gbMemberDetail.Controls.Add(this.pnFullName);
            this.gbMemberDetail.Controls.Add(this.btnCancel);
            this.gbMemberDetail.Controls.Add(this.btnSave);
            this.gbMemberDetail.Controls.Add(this.pnAddress);
            this.gbMemberDetail.Controls.Add(this.pnRole);
            this.gbMemberDetail.Controls.Add(this.pnPassword);
            this.gbMemberDetail.Controls.Add(this.pnEmail);
            this.gbMemberDetail.Controls.Add(this.pnUserName);
            this.gbMemberDetail.Location = new System.Drawing.Point(3, 1);
            this.gbMemberDetail.Name = "gbMemberDetail";
            this.gbMemberDetail.Size = new System.Drawing.Size(426, 606);
            this.gbMemberDetail.TabIndex = 0;
            this.gbMemberDetail.TabStop = false;
            // 
            // pnPhoneNumber
            // 
            this.pnPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.pnPhoneNumber.Controls.Add(this.lbPhoneNumber);
            this.pnPhoneNumber.Location = new System.Drawing.Point(6, 275);
            this.pnPhoneNumber.Name = "pnPhoneNumber";
            this.pnPhoneNumber.Size = new System.Drawing.Size(414, 60);
            this.pnPhoneNumber.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(156, 15);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(244, 27);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPhoneNumber.Location = new System.Drawing.Point(13, 21);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(108, 20);
            this.lbPhoneNumber.TabIndex = 0;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // pnActive
            // 
            this.pnActive.Controls.Add(this.rbNo);
            this.pnActive.Controls.Add(this.rbYes);
            this.pnActive.Controls.Add(this.label1);
            this.pnActive.Location = new System.Drawing.Point(6, 473);
            this.pnActive.Name = "pnActive";
            this.pnActive.Size = new System.Drawing.Size(414, 60);
            this.pnActive.TabIndex = 6;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(248, 21);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(50, 24);
            this.rbNo.TabIndex = 10;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(156, 20);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(51, 24);
            this.rbYes.TabIndex = 9;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Yes";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Active";
            // 
            // pnFullName
            // 
            this.pnFullName.Controls.Add(this.txtFullName);
            this.pnFullName.Controls.Add(this.lbFullName);
            this.pnFullName.Location = new System.Drawing.Point(3, 77);
            this.pnFullName.Name = "pnFullName";
            this.pnFullName.Size = new System.Drawing.Size(417, 60);
            this.pnFullName.TabIndex = 8;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(156, 15);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(244, 27);
            this.txtFullName.TabIndex = 2;
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFullName.Location = new System.Drawing.Point(13, 21);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(76, 20);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "Full Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(210, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(88, 559);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnAddress
            // 
            this.pnAddress.Controls.Add(this.txtAddress);
            this.pnAddress.Controls.Add(this.lbAddress);
            this.pnAddress.Location = new System.Drawing.Point(6, 341);
            this.pnAddress.Name = "pnAddress";
            this.pnAddress.Size = new System.Drawing.Size(414, 60);
            this.pnAddress.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(156, 15);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(244, 27);
            this.txtAddress.TabIndex = 6;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddress.Location = new System.Drawing.Point(13, 21);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(62, 20);
            this.lbAddress.TabIndex = 0;
            this.lbAddress.Text = "Address";
            // 
            // pnRole
            // 
            this.pnRole.Controls.Add(this.rbStaff);
            this.pnRole.Controls.Add(this.rbAdmin);
            this.pnRole.Controls.Add(this.lbRole);
            this.pnRole.Location = new System.Drawing.Point(6, 407);
            this.pnRole.Name = "pnRole";
            this.pnRole.Size = new System.Drawing.Size(414, 60);
            this.pnRole.TabIndex = 2;
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(248, 21);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(61, 24);
            this.rbStaff.TabIndex = 8;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Checked = true;
            this.rbAdmin.Location = new System.Drawing.Point(156, 21);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(74, 24);
            this.rbAdmin.TabIndex = 7;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRole.Location = new System.Drawing.Point(13, 21);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(39, 20);
            this.lbRole.TabIndex = 0;
            this.lbRole.Text = "Role";
            // 
            // pnPassword
            // 
            this.pnPassword.Controls.Add(this.txtPassword);
            this.pnPassword.Controls.Add(this.lbPassword);
            this.pnPassword.Location = new System.Drawing.Point(6, 209);
            this.pnPassword.Name = "pnPassword";
            this.pnPassword.Size = new System.Drawing.Size(414, 60);
            this.pnPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(244, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(13, 21);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 20);
            this.lbPassword.TabIndex = 0;
            this.lbPassword.Text = "Password";
            // 
            // pnEmail
            // 
            this.pnEmail.Controls.Add(this.txtEmail);
            this.pnEmail.Controls.Add(this.lbEmail);
            this.pnEmail.Location = new System.Drawing.Point(6, 143);
            this.pnEmail.Name = "pnEmail";
            this.pnEmail.Size = new System.Drawing.Size(420, 60);
            this.pnEmail.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 15);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(13, 21);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 20);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // pnUserName
            // 
            this.pnUserName.Controls.Add(this.txtUserName);
            this.pnUserName.Controls.Add(this.lbName);
            this.pnUserName.Location = new System.Drawing.Point(3, 11);
            this.pnUserName.Name = "pnUserName";
            this.pnUserName.Size = new System.Drawing.Size(417, 60);
            this.pnUserName.TabIndex = 2;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(156, 15);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(244, 27);
            this.txtUserName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(13, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "UserName";
            // 
            // frmUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 614);
            this.Controls.Add(this.gbMemberDetail);
            this.Name = "frmUserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Detail";
            this.Load += new System.EventHandler(this.frmUserDetail_Load);
            this.gbMemberDetail.ResumeLayout(false);
            this.pnPhoneNumber.ResumeLayout(false);
            this.pnPhoneNumber.PerformLayout();
            this.pnActive.ResumeLayout(false);
            this.pnActive.PerformLayout();
            this.pnFullName.ResumeLayout(false);
            this.pnFullName.PerformLayout();
            this.pnAddress.ResumeLayout(false);
            this.pnAddress.PerformLayout();
            this.pnRole.ResumeLayout(false);
            this.pnRole.PerformLayout();
            this.pnPassword.ResumeLayout(false);
            this.pnPassword.PerformLayout();
            this.pnEmail.ResumeLayout(false);
            this.pnEmail.PerformLayout();
            this.pnUserName.ResumeLayout(false);
            this.pnUserName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMemberDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Panel pnRole;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Panel pnPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel pnEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel pnUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Panel pnActive;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbAdmin;
    }
}