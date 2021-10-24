
namespace CakeSellingWinApp
{
    partial class frmCakeList
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
            this.dgvCakeList = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelListView = new System.Windows.Forms.Panel();
            this.panelAction = new System.Windows.Forms.Panel();
            this.lbListStatus = new System.Windows.Forms.Label();
            this.ActionBox = new System.Windows.Forms.GroupBox();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.ListFilterBox = new System.Windows.Forms.GroupBox();
            this.cboStatusFilter = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.lbSearchError = new System.Windows.Forms.Label();
            this.lbSearchName = new System.Windows.Forms.Label();
            this.lbSearchID = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCakeList)).BeginInit();
            this.panelListView.SuspendLayout();
            this.panelAction.SuspendLayout();
            this.ActionBox.SuspendLayout();
            this.ListFilterBox.SuspendLayout();
            this.SearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCakeList
            // 
            this.dgvCakeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCakeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCakeList.Location = new System.Drawing.Point(12, 8);
            this.dgvCakeList.Name = "dgvCakeList";
            this.dgvCakeList.RowTemplate.Height = 25;
            this.dgvCakeList.Size = new System.Drawing.Size(750, 320);
            this.dgvCakeList.TabIndex = 0;
            this.dgvCakeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCakeList_CellClick);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.Location = new System.Drawing.Point(21, 22);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(21, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelListView
            // 
            this.panelListView.Controls.Add(this.dgvCakeList);
            this.panelListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListView.Location = new System.Drawing.Point(0, 160);
            this.panelListView.Name = "panelListView";
            this.panelListView.Size = new System.Drawing.Size(774, 340);
            this.panelListView.TabIndex = 3;
            // 
            // panelAction
            // 
            this.panelAction.Controls.Add(this.lbListStatus);
            this.panelAction.Controls.Add(this.ActionBox);
            this.panelAction.Controls.Add(this.ListFilterBox);
            this.panelAction.Controls.Add(this.SearchBox);
            this.panelAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAction.Location = new System.Drawing.Point(0, 0);
            this.panelAction.Name = "panelAction";
            this.panelAction.Size = new System.Drawing.Size(774, 159);
            this.panelAction.TabIndex = 4;
            // 
            // lbListStatus
            // 
            this.lbListStatus.AutoSize = true;
            this.lbListStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbListStatus.Location = new System.Drawing.Point(40, 137);
            this.lbListStatus.Name = "lbListStatus";
            this.lbListStatus.Size = new System.Drawing.Size(0, 20);
            this.lbListStatus.TabIndex = 13;
            // 
            // ActionBox
            // 
            this.ActionBox.Controls.Add(this.btnReload);
            this.ActionBox.Controls.Add(this.btnChangeStatus);
            this.ActionBox.Controls.Add(this.btnAdd);
            this.ActionBox.Location = new System.Drawing.Point(554, 23);
            this.ActionBox.Name = "ActionBox";
            this.ActionBox.Size = new System.Drawing.Size(117, 112);
            this.ActionBox.TabIndex = 12;
            this.ActionBox.TabStop = false;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeStatus.Location = new System.Drawing.Point(21, 80);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(75, 23);
            this.btnChangeStatus.TabIndex = 4;
            this.btnChangeStatus.Text = "Inactive";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // ListFilterBox
            // 
            this.ListFilterBox.Controls.Add(this.cboStatusFilter);
            this.ListFilterBox.Location = new System.Drawing.Point(372, 24);
            this.ListFilterBox.Name = "ListFilterBox";
            this.ListFilterBox.Size = new System.Drawing.Size(176, 112);
            this.ListFilterBox.TabIndex = 11;
            this.ListFilterBox.TabStop = false;
            this.ListFilterBox.Text = "Status";
            // 
            // cboStatusFilter
            // 
            this.cboStatusFilter.FormattingEnabled = true;
            this.cboStatusFilter.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatusFilter.Location = new System.Drawing.Point(27, 53);
            this.cboStatusFilter.Name = "cboStatusFilter";
            this.cboStatusFilter.Size = new System.Drawing.Size(121, 23);
            this.cboStatusFilter.TabIndex = 7;
            this.cboStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cboStatusFilter_SelectedIndexChanged);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.lbSearchError);
            this.SearchBox.Controls.Add(this.lbSearchName);
            this.SearchBox.Controls.Add(this.lbSearchID);
            this.SearchBox.Controls.Add(this.txtSearchName);
            this.SearchBox.Controls.Add(this.txtSearchID);
            this.SearchBox.Controls.Add(this.btnSearch);
            this.SearchBox.Location = new System.Drawing.Point(83, 23);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(283, 112);
            this.SearchBox.TabIndex = 10;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // lbSearchError
            // 
            this.lbSearchError.AutoSize = true;
            this.lbSearchError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSearchError.ForeColor = System.Drawing.Color.Red;
            this.lbSearchError.Location = new System.Drawing.Point(23, 86);
            this.lbSearchError.Name = "lbSearchError";
            this.lbSearchError.Size = new System.Drawing.Size(0, 15);
            this.lbSearchError.TabIndex = 14;
            // 
            // lbSearchName
            // 
            this.lbSearchName.AutoSize = true;
            this.lbSearchName.Location = new System.Drawing.Point(23, 57);
            this.lbSearchName.Name = "lbSearchName";
            this.lbSearchName.Size = new System.Drawing.Size(39, 15);
            this.lbSearchName.TabIndex = 12;
            this.lbSearchName.Text = "Name";
            // 
            // lbSearchID
            // 
            this.lbSearchID.AutoSize = true;
            this.lbSearchID.Location = new System.Drawing.Point(23, 26);
            this.lbSearchID.Name = "lbSearchID";
            this.lbSearchID.Size = new System.Drawing.Size(18, 15);
            this.lbSearchID.TabIndex = 11;
            this.lbSearchID.Text = "ID";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(68, 54);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(184, 23);
            this.txtSearchName.TabIndex = 7;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(68, 22);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(184, 23);
            this.txtSearchID.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(177, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmCakeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.panelAction);
            this.Controls.Add(this.panelListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCakeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCakeList";
            this.Load += new System.EventHandler(this.frmCakeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCakeList)).EndInit();
            this.panelListView.ResumeLayout(false);
            this.panelAction.ResumeLayout(false);
            this.panelAction.PerformLayout();
            this.ActionBox.ResumeLayout(false);
            this.ListFilterBox.ResumeLayout(false);
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCakeList;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelListView;
        private System.Windows.Forms.Panel panelAction;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnChangeStatus;
        private System.Windows.Forms.ComboBox cboStatusFilter;
        private System.Windows.Forms.GroupBox ActionBox;
        private System.Windows.Forms.GroupBox ListFilterBox;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.Label lbSearchName;
        private System.Windows.Forms.Label lbSearchID;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lbListStatus;
        private System.Windows.Forms.Label lbSearchError;
    }
}