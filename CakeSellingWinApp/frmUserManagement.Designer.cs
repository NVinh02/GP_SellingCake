
namespace CakeSellingWinApp
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.dvgUserList = new System.Windows.Forms.DataGridView();
            this.gbRoleActive = new System.Windows.Forms.GroupBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatusError = new System.Windows.Forms.Label();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.lbSearchError = new System.Windows.Forms.Label();
            this.lbSearchUserName = new System.Windows.Forms.Label();
            this.lbSearchFullName = new System.Windows.Forms.Label();
            this.txtSearchUserName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchFullName = new System.Windows.Forms.TextBox();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserList)).BeginInit();
            this.gbRoleActive.SuspendLayout();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(19, 21);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 22);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Reload";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(19, 53);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(91, 22);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Add";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnActive
            // 
            this.btnActive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActive.Location = new System.Drawing.Point(19, 87);
            this.btnActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(91, 22);
            this.btnActive.TabIndex = 17;
            this.btnActive.Text = "Active";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.btnLoad);
            this.gbButton.Controls.Add(this.btnCreate);
            this.gbButton.Controls.Add(this.btnActive);
            this.gbButton.Location = new System.Drawing.Point(555, 11);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(131, 123);
            this.gbButton.TabIndex = 21;
            this.gbButton.TabStop = false;
            // 
            // dvgUserList
            // 
            this.dvgUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUserList.Location = new System.Drawing.Point(12, 183);
            this.dvgUserList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dvgUserList.Name = "dvgUserList";
            this.dvgUserList.RowHeadersWidth = 51;
            this.dvgUserList.RowTemplate.Height = 29;
            this.dvgUserList.Size = new System.Drawing.Size(750, 307);
            this.dvgUserList.TabIndex = 18;
            this.dvgUserList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUserList_CellClick_1);
            this.dvgUserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUserList_CellDoubleClick_1);
            // 
            // gbRoleActive
            // 
            this.gbRoleActive.Controls.Add(this.cbStatus);
            this.gbRoleActive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRoleActive.Location = new System.Drawing.Point(348, 11);
            this.gbRoleActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRoleActive.Name = "gbRoleActive";
            this.gbRoleActive.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbRoleActive.Size = new System.Drawing.Size(201, 137);
            this.gbRoleActive.TabIndex = 17;
            this.gbRoleActive.TabStop = false;
            this.gbRoleActive.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(35, 54);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(137, 23);
            this.cbStatus.TabIndex = 13;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // lbStatusError
            // 
            this.lbStatusError.AutoSize = true;
            this.lbStatusError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStatusError.ForeColor = System.Drawing.Color.Black;
            this.lbStatusError.Location = new System.Drawing.Point(22, 160);
            this.lbStatusError.Name = "lbStatusError";
            this.lbStatusError.Size = new System.Drawing.Size(100, 21);
            this.lbStatusError.TabIndex = 21;
            this.lbStatusError.Text = "lbStatusError";
            // 
            // gbName
            // 
            this.gbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbName.Controls.Add(this.lbSearchError);
            this.gbName.Controls.Add(this.lbSearchUserName);
            this.gbName.Controls.Add(this.lbSearchFullName);
            this.gbName.Controls.Add(this.txtSearchUserName);
            this.gbName.Controls.Add(this.btnSearch);
            this.gbName.Controls.Add(this.txtSearchFullName);
            this.gbName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbName.Location = new System.Drawing.Point(80, 11);
            this.gbName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbName.Name = "gbName";
            this.gbName.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbName.Size = new System.Drawing.Size(262, 137);
            this.gbName.TabIndex = 13;
            this.gbName.TabStop = false;
            this.gbName.Text = "Search Full Name/ UserName";
            // 
            // lbSearchError
            // 
            this.lbSearchError.AutoSize = true;
            this.lbSearchError.ForeColor = System.Drawing.Color.Red;
            this.lbSearchError.Location = new System.Drawing.Point(6, 108);
            this.lbSearchError.Name = "lbSearchError";
            this.lbSearchError.Size = new System.Drawing.Size(77, 15);
            this.lbSearchError.TabIndex = 20;
            this.lbSearchError.Text = "lbSearchError";
            // 
            // lbSearchUserName
            // 
            this.lbSearchUserName.AutoSize = true;
            this.lbSearchUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchUserName.Location = new System.Drawing.Point(5, 62);
            this.lbSearchUserName.Name = "lbSearchUserName";
            this.lbSearchUserName.Size = new System.Drawing.Size(62, 15);
            this.lbSearchUserName.TabIndex = 19;
            this.lbSearchUserName.Text = "UserName";
            // 
            // lbSearchFullName
            // 
            this.lbSearchFullName.AutoSize = true;
            this.lbSearchFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchFullName.Location = new System.Drawing.Point(5, 28);
            this.lbSearchFullName.Name = "lbSearchFullName";
            this.lbSearchFullName.Size = new System.Drawing.Size(61, 15);
            this.lbSearchFullName.TabIndex = 18;
            this.lbSearchFullName.Text = "Full Name";
            // 
            // txtSearchUserName
            // 
            this.txtSearchUserName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchUserName.Location = new System.Drawing.Point(72, 64);
            this.txtSearchUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchUserName.Name = "txtSearchUserName";
            this.txtSearchUserName.Size = new System.Drawing.Size(176, 23);
            this.txtSearchUserName.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(166, 108);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchFullName
            // 
            this.txtSearchFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchFullName.Location = new System.Drawing.Point(72, 25);
            this.txtSearchFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchFullName.Name = "txtSearchFullName";
            this.txtSearchFullName.Size = new System.Drawing.Size(176, 23);
            this.txtSearchFullName.TabIndex = 10;
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.lbStatusError);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.dvgUserList);
            this.Controls.Add(this.gbName);
            this.Controls.Add(this.gbRoleActive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUserList)).EndInit();
            this.gbRoleActive.ResumeLayout(false);
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox txtSearchFullName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbRoleActive;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbSearchUserName;
        private System.Windows.Forms.Label lbSearchFullName;
        private System.Windows.Forms.TextBox txtSearchUserName;
        private System.Windows.Forms.DataGridView dvgUserList;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Label lbSearchError;
        private System.Windows.Forms.Label lbStatusError;
    }
}