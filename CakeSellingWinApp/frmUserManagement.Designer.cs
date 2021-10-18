
namespace MyStoreWinApp
{
    partial class frmUserManagement
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
            this.bntLoad = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.dvgUserList = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.gbRoleActive = new System.Windows.Forms.GroupBox();
            this.lbSearchStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.lbSearchUserName = new System.Windows.Forms.Label();
            this.lbSearchFullName = new System.Windows.Forms.Label();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchFullName = new System.Windows.Forms.TextBox();
            this.gbInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserList)).BeginInit();
            this.pnButton.SuspendLayout();
            this.gbRoleActive.SuspendLayout();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // bntLoad
            // 
            this.bntLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bntLoad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntLoad.Location = new System.Drawing.Point(35, 21);
            this.bntLoad.Name = "bntLoad";
            this.bntLoad.Size = new System.Drawing.Size(104, 29);
            this.bntLoad.TabIndex = 15;
            this.bntLoad.Text = "Reload";
            this.bntLoad.UseVisualStyleBackColor = true;
            this.bntLoad.Click += new System.EventHandler(this.bntLoad_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(35, 64);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 29);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Add";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActive.Location = new System.Drawing.Point(35, 109);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(104, 29);
            this.btnActive.TabIndex = 17;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.Location = new System.Drawing.Point(418, 518);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbInformation
            // 
            this.gbInformation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbInformation.Controls.Add(this.dvgUserList);
            this.gbInformation.Controls.Add(this.txtID);
            this.gbInformation.Controls.Add(this.pnButton);
            this.gbInformation.Controls.Add(this.btnClose);
            this.gbInformation.Controls.Add(this.gbRoleActive);
            this.gbInformation.Controls.Add(this.gbName);
            this.gbInformation.Location = new System.Drawing.Point(12, 15);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(910, 573);
            this.gbInformation.TabIndex = 10;
            this.gbInformation.TabStop = false;
            // 
            // dvgUserList
            // 
            this.dvgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUserList.Location = new System.Drawing.Point(12, 226);
            this.dvgUserList.Name = "dvgUserList";
            this.dvgUserList.RowHeadersWidth = 51;
            this.dvgUserList.RowTemplate.Height = 29;
            this.dvgUserList.Size = new System.Drawing.Size(863, 261);
            this.dvgUserList.TabIndex = 18;
            this.dvgUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUserList_CellClick_1);
            this.dvgUserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUserList_CellDoubleClick_1);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 353);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(112, 27);
            this.txtID.TabIndex = 20;
            // 
            // pnButton
            // 
            this.pnButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnButton.Controls.Add(this.bntLoad);
            this.pnButton.Controls.Add(this.btnCreate);
            this.pnButton.Controls.Add(this.btnActive);
            this.pnButton.Location = new System.Drawing.Point(705, 27);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(170, 155);
            this.pnButton.TabIndex = 19;
            // 
            // gbRoleActive
            // 
            this.gbRoleActive.Controls.Add(this.lbSearchStatus);
            this.gbRoleActive.Controls.Add(this.cbStatus);
            this.gbRoleActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRoleActive.Location = new System.Drawing.Point(356, 36);
            this.gbRoleActive.Name = "gbRoleActive";
            this.gbRoleActive.Size = new System.Drawing.Size(313, 92);
            this.gbRoleActive.TabIndex = 17;
            this.gbRoleActive.TabStop = false;
            this.gbRoleActive.Text = "Search Status";
            // 
            // lbSearchStatus
            // 
            this.lbSearchStatus.AutoSize = true;
            this.lbSearchStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchStatus.Location = new System.Drawing.Point(6, 32);
            this.lbSearchStatus.Name = "lbSearchStatus";
            this.lbSearchStatus.Size = new System.Drawing.Size(49, 20);
            this.lbSearchStatus.TabIndex = 18;
            this.lbSearchStatus.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(106, 24);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(205, 31);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // gbName
            // 
            this.gbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbName.Controls.Add(this.lbSearchUserName);
            this.gbName.Controls.Add(this.lbSearchFullName);
            this.gbName.Controls.Add(this.txtSearchUserName);
            this.gbName.Controls.Add(this.btnSearch);
            this.gbName.Controls.Add(this.txtSearchFullName);
            this.gbName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbName.Location = new System.Drawing.Point(12, 17);
            this.gbName.Name = "gbName";
            this.gbName.Size = new System.Drawing.Size(313, 164);
            this.gbName.TabIndex = 13;
            this.gbName.TabStop = false;
            this.gbName.Text = "Search Full Name/ UserName";
            // 
            // lbSearchUserName
            // 
            this.lbSearchUserName.AutoSize = true;
            this.lbSearchUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchUserName.Location = new System.Drawing.Point(6, 82);
            this.lbSearchUserName.Name = "lbSearchUserName";
            this.lbSearchUserName.Size = new System.Drawing.Size(78, 20);
            this.lbSearchUserName.TabIndex = 19;
            this.lbSearchUserName.Text = "UserName";
            // 
            // lbSearchFullName
            // 
            this.lbSearchFullName.AutoSize = true;
            this.lbSearchFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchFullName.Location = new System.Drawing.Point(6, 37);
            this.lbSearchFullName.Name = "lbSearchFullName";
            this.lbSearchFullName.Size = new System.Drawing.Size(76, 20);
            this.lbSearchFullName.TabIndex = 18;
            this.lbSearchFullName.Text = "Full Name";
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Location = new System.Drawing.Point(112, 81);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(201, 30);
            this.txtSearchUserName.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(101, 129);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchFullName
            // 
            this.txtSearchFullName.Location = new System.Drawing.Point(112, 29);
            this.txtSearchFullName.Name = "txtSearchFullName";
            this.txtSearchFullName.Size = new System.Drawing.Size(201, 30);
            this.txtSearchFullName.TabIndex = 10;
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(958, 602);
            this.Controls.Add(this.gbInformation);
            this.Name = "frmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.gbInformation.ResumeLayout(false);
            this.gbInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserList)).EndInit();
            this.pnButton.ResumeLayout(false);
            this.gbRoleActive.ResumeLayout(false);
            this.gbRoleActive.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bntLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtSearchFullName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbRoleActive;
        private System.Windows.Forms.Label lbSearchStatus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbSearchUserName;
        private System.Windows.Forms.Label lbSearchFullName;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dvgUserList;
    }
}