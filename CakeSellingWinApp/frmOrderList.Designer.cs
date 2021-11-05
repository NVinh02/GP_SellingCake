
namespace CakeSellingWinApp
{
    partial class frmOrderList
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnFilterDeliveryOrder = new System.Windows.Forms.Button();
            this.btnTakewayOrder = new System.Windows.Forms.Button();
            this.gpFilter = new System.Windows.Forms.GroupBox();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.gbButton = new System.Windows.Forms.GroupBox();
            this.gbOrderSearch = new System.Windows.Forms.GroupBox();
            this.lbSearchIDError = new System.Windows.Forms.Label();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.btnSearchOrderID = new System.Windows.Forms.Button();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.gbCustomerSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomerNameAndPhone = new System.Windows.Forms.Button();
            this.lbCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbListStatus = new System.Windows.Forms.Label();
            this.lbCustomerSearchError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.gpFilter.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.gbButton.SuspendLayout();
            this.gbOrderSearch.SuspendLayout();
            this.gbCustomerSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(125, 17);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 43;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(22, 16);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 41;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 205);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowTemplate.Height = 25;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(734, 244);
            this.dgvOrderList.TabIndex = 40;
            this.dgvOrderList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellClick);
            // 
            // btnFilterDeliveryOrder
            // 
            this.btnFilterDeliveryOrder.Location = new System.Drawing.Point(23, 22);
            this.btnFilterDeliveryOrder.Name = "btnFilterDeliveryOrder";
            this.btnFilterDeliveryOrder.Size = new System.Drawing.Size(93, 23);
            this.btnFilterDeliveryOrder.TabIndex = 44;
            this.btnFilterDeliveryOrder.Text = "Delivery Order";
            this.btnFilterDeliveryOrder.UseVisualStyleBackColor = true;
            this.btnFilterDeliveryOrder.Click += new System.EventHandler(this.btnFilterDeliveryOrder_Click);
            // 
            // btnTakewayOrder
            // 
            this.btnTakewayOrder.Location = new System.Drawing.Point(23, 61);
            this.btnTakewayOrder.Name = "btnTakewayOrder";
            this.btnTakewayOrder.Size = new System.Drawing.Size(93, 23);
            this.btnTakewayOrder.TabIndex = 45;
            this.btnTakewayOrder.Text = "Takeaway Order";
            this.btnTakewayOrder.UseVisualStyleBackColor = true;
            this.btnTakewayOrder.Click += new System.EventHandler(this.btnTakewayOrder_Click);
            // 
            // gpFilter
            // 
            this.gpFilter.Controls.Add(this.btnFilterDeliveryOrder);
            this.gpFilter.Controls.Add(this.btnTakewayOrder);
            this.gpFilter.Location = new System.Drawing.Point(572, 12);
            this.gpFilter.Name = "gpFilter";
            this.gpFilter.Size = new System.Drawing.Size(139, 100);
            this.gpFilter.TabIndex = 46;
            this.gpFilter.TabStop = false;
            this.gpFilter.Text = "Filter";
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.gbButton);
            this.gpSearch.Controls.Add(this.gbOrderSearch);
            this.gpSearch.Controls.Add(this.gbCustomerSearch);
            this.gpSearch.Location = new System.Drawing.Point(43, 12);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(523, 166);
            this.gpSearch.TabIndex = 47;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Search";
            // 
            // gbButton
            // 
            this.gbButton.Controls.Add(this.btnReload);
            this.gbButton.Controls.Add(this.btnNew);
            this.gbButton.Location = new System.Drawing.Point(289, 112);
            this.gbButton.Name = "gbButton";
            this.gbButton.Size = new System.Drawing.Size(217, 45);
            this.gbButton.TabIndex = 57;
            this.gbButton.TabStop = false;
            // 
            // gbOrderSearch
            // 
            this.gbOrderSearch.Controls.Add(this.lbSearchIDError);
            this.gbOrderSearch.Controls.Add(this.lbOrderID);
            this.gbOrderSearch.Controls.Add(this.btnSearchOrderID);
            this.gbOrderSearch.Controls.Add(this.txtOrderID);
            this.gbOrderSearch.Location = new System.Drawing.Point(288, 22);
            this.gbOrderSearch.Name = "gbOrderSearch";
            this.gbOrderSearch.Size = new System.Drawing.Size(218, 84);
            this.gbOrderSearch.TabIndex = 56;
            this.gbOrderSearch.TabStop = false;
            this.gbOrderSearch.Text = "Order";
            // 
            // lbSearchIDError
            // 
            this.lbSearchIDError.AutoSize = true;
            this.lbSearchIDError.ForeColor = System.Drawing.Color.Red;
            this.lbSearchIDError.Location = new System.Drawing.Point(6, 59);
            this.lbSearchIDError.Name = "lbSearchIDError";
            this.lbSearchIDError.Size = new System.Drawing.Size(88, 15);
            this.lbSearchIDError.TabIndex = 55;
            this.lbSearchIDError.Text = "lbSearchIDError";
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(23, 23);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(18, 15);
            this.lbOrderID.TabIndex = 54;
            this.lbOrderID.Text = "ID";
            // 
            // btnSearchOrderID
            // 
            this.btnSearchOrderID.Location = new System.Drawing.Point(137, 55);
            this.btnSearchOrderID.Name = "btnSearchOrderID";
            this.btnSearchOrderID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOrderID.TabIndex = 52;
            this.btnSearchOrderID.Text = "Search";
            this.btnSearchOrderID.UseVisualStyleBackColor = true;
            this.btnSearchOrderID.Click += new System.EventHandler(this.btnSearchOrderID_Click);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(47, 20);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(165, 23);
            this.txtOrderID.TabIndex = 50;
            // 
            // gbCustomerSearch
            // 
            this.gbCustomerSearch.Controls.Add(this.lbCustomerSearchError);
            this.gbCustomerSearch.Controls.Add(this.btnSearchCustomerNameAndPhone);
            this.gbCustomerSearch.Controls.Add(this.lbCustomerPhoneNumber);
            this.gbCustomerSearch.Controls.Add(this.txtCustomerPhone);
            this.gbCustomerSearch.Controls.Add(this.txtCustomerName);
            this.gbCustomerSearch.Controls.Add(this.lbCustomerName);
            this.gbCustomerSearch.Location = new System.Drawing.Point(15, 22);
            this.gbCustomerSearch.Name = "gbCustomerSearch";
            this.gbCustomerSearch.Size = new System.Drawing.Size(258, 135);
            this.gbCustomerSearch.TabIndex = 55;
            this.gbCustomerSearch.TabStop = false;
            this.gbCustomerSearch.Text = "Customer";
            // 
            // btnSearchCustomerNameAndPhone
            // 
            this.btnSearchCustomerNameAndPhone.Location = new System.Drawing.Point(170, 106);
            this.btnSearchCustomerNameAndPhone.Name = "btnSearchCustomerNameAndPhone";
            this.btnSearchCustomerNameAndPhone.Size = new System.Drawing.Size(75, 23);
            this.btnSearchCustomerNameAndPhone.TabIndex = 56;
            this.btnSearchCustomerNameAndPhone.Text = "Search";
            this.btnSearchCustomerNameAndPhone.UseVisualStyleBackColor = true;
            this.btnSearchCustomerNameAndPhone.Click += new System.EventHandler(this.btnSearchCustomerNameAndPhone_Click);
            // 
            // lbCustomerPhoneNumber
            // 
            this.lbCustomerPhoneNumber.AutoSize = true;
            this.lbCustomerPhoneNumber.Location = new System.Drawing.Point(11, 64);
            this.lbCustomerPhoneNumber.Name = "lbCustomerPhoneNumber";
            this.lbCustomerPhoneNumber.Size = new System.Drawing.Size(41, 15);
            this.lbCustomerPhoneNumber.TabIndex = 53;
            this.lbCustomerPhoneNumber.Text = "Phone";
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Location = new System.Drawing.Point(58, 61);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(187, 23);
            this.txtCustomerPhone.TabIndex = 49;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(58, 20);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(187, 23);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(10, 23);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(39, 15);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Name";
            // 
            // lbListStatus
            // 
            this.lbListStatus.AutoSize = true;
            this.lbListStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbListStatus.Location = new System.Drawing.Point(12, 181);
            this.lbListStatus.Name = "lbListStatus";
            this.lbListStatus.Size = new System.Drawing.Size(0, 21);
            this.lbListStatus.TabIndex = 48;
            // 
            // lbCustomerSearchError
            // 
            this.lbCustomerSearchError.AutoSize = true;
            this.lbCustomerSearchError.ForeColor = System.Drawing.Color.Red;
            this.lbCustomerSearchError.Location = new System.Drawing.Point(6, 110);
            this.lbCustomerSearchError.Name = "lbCustomerSearchError";
            this.lbCustomerSearchError.Size = new System.Drawing.Size(129, 15);
            this.lbCustomerSearchError.TabIndex = 56;
            this.lbCustomerSearchError.Text = "lbCustomerSearchError";
            // 
            // frmOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 461);
            this.Controls.Add(this.lbListStatus);
            this.Controls.Add(this.gpSearch);
            this.Controls.Add(this.gpFilter);
            this.Controls.Add(this.dgvOrderList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderList";
            this.Load += new System.EventHandler(this.frmOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.gpFilter.ResumeLayout(false);
            this.gpSearch.ResumeLayout(false);
            this.gbButton.ResumeLayout(false);
            this.gbOrderSearch.ResumeLayout(false);
            this.gbOrderSearch.PerformLayout();
            this.gbCustomerSearch.ResumeLayout(false);
            this.gbCustomerSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnFilterDeliveryOrder;
        private System.Windows.Forms.Button btnTakewayOrder;
        private System.Windows.Forms.GroupBox gpFilter;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSearchOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbCustomerPhoneNumber;
        private System.Windows.Forms.GroupBox gbCustomerSearch;
        private System.Windows.Forms.GroupBox gbOrderSearch;
        private System.Windows.Forms.GroupBox gbButton;
        private System.Windows.Forms.Label lbListStatus;
        private System.Windows.Forms.Label lbSearchIDError;
        private System.Windows.Forms.Button btnSearchCustomerNameAndPhone;
        private System.Windows.Forms.Label lbCustomerSearchError;
    }
}