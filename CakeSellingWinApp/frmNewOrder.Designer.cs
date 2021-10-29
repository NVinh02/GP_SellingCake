
namespace CakeSellingWinApp
{
    partial class frmNewOrder
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
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtOrderPrice = new System.Windows.Forms.TextBox();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.rbtnDelivery = new System.Windows.Forms.RadioButton();
            this.rbtnTakeaway = new System.Windows.Forms.RadioButton();
            this.lbOrderPrice = new System.Windows.Forms.Label();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbCustomerPhoneNumber = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.dtpShippingDate = new System.Windows.Forms.DateTimePicker();
            this.lbShippingDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.MaskedTextBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.dgvDetailList = new System.Windows.Forms.DataGridView();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbProduct = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbOrderInfo = new System.Windows.Forms.GroupBox();
            this.lbShippingDateError = new System.Windows.Forms.Label();
            this.lbCustomerAddressError = new System.Windows.Forms.Label();
            this.lbCustomerPhoneNumberError = new System.Windows.Forms.Label();
            this.lbCustomerNameError = new System.Windows.Forms.Label();
            this.lbShippingMethod = new System.Windows.Forms.Label();
            this.gbOrderDetailAction = new System.Windows.Forms.GroupBox();
            this.lbStockError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailList)).BeginInit();
            this.gbOrderInfo.SuspendLayout();
            this.gbOrderDetailAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(266, 354);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(60, 23);
            this.txtProductId.TabIndex = 92;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(509, 18);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(199, 23);
            this.txtCustomerAddress.TabIndex = 91;
            // 
            // txtOrderPrice
            // 
            this.txtOrderPrice.Location = new System.Drawing.Point(119, 125);
            this.txtOrderPrice.Name = "txtOrderPrice";
            this.txtOrderPrice.ReadOnly = true;
            this.txtOrderPrice.Size = new System.Drawing.Size(193, 23);
            this.txtOrderPrice.TabIndex = 90;
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(119, 70);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(193, 23);
            this.txtCustomerPhoneNumber.TabIndex = 89;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(119, 18);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(193, 23);
            this.txtCustomerName.TabIndex = 88;
            // 
            // rbtnDelivery
            // 
            this.rbtnDelivery.AutoSize = true;
            this.rbtnDelivery.Location = new System.Drawing.Point(613, 123);
            this.rbtnDelivery.Name = "rbtnDelivery";
            this.rbtnDelivery.Size = new System.Drawing.Size(67, 19);
            this.rbtnDelivery.TabIndex = 87;
            this.rbtnDelivery.TabStop = true;
            this.rbtnDelivery.Text = "Delivery";
            this.rbtnDelivery.UseVisualStyleBackColor = true;
            this.rbtnDelivery.CheckedChanged += new System.EventHandler(this.rbtnDelivery_CheckedChanged);
            // 
            // rbtnTakeaway
            // 
            this.rbtnTakeaway.AutoSize = true;
            this.rbtnTakeaway.Location = new System.Drawing.Point(509, 123);
            this.rbtnTakeaway.Name = "rbtnTakeaway";
            this.rbtnTakeaway.Size = new System.Drawing.Size(75, 19);
            this.rbtnTakeaway.TabIndex = 86;
            this.rbtnTakeaway.TabStop = true;
            this.rbtnTakeaway.Text = "Takeaway";
            this.rbtnTakeaway.UseVisualStyleBackColor = true;
            this.rbtnTakeaway.CheckedChanged += new System.EventHandler(this.rbtnTakeaway_CheckedChanged);
            // 
            // lbOrderPrice
            // 
            this.lbOrderPrice.AutoSize = true;
            this.lbOrderPrice.Location = new System.Drawing.Point(16, 125);
            this.lbOrderPrice.Name = "lbOrderPrice";
            this.lbOrderPrice.Size = new System.Drawing.Size(66, 15);
            this.lbOrderPrice.TabIndex = 85;
            this.lbOrderPrice.Text = "Order Price";
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Location = new System.Drawing.Point(387, 21);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(104, 15);
            this.lbCustomerAddress.TabIndex = 84;
            this.lbCustomerAddress.Text = "Customer Address";
            // 
            // lbCustomerPhoneNumber
            // 
            this.lbCustomerPhoneNumber.AutoSize = true;
            this.lbCustomerPhoneNumber.Location = new System.Drawing.Point(16, 73);
            this.lbCustomerPhoneNumber.Name = "lbCustomerPhoneNumber";
            this.lbCustomerPhoneNumber.Size = new System.Drawing.Size(96, 15);
            this.lbCustomerPhoneNumber.TabIndex = 83;
            this.lbCustomerPhoneNumber.Text = "Customer Phone";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(16, 19);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(94, 15);
            this.lbCustomerName.TabIndex = 82;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // dtpShippingDate
            // 
            this.dtpShippingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpShippingDate.Location = new System.Drawing.Point(509, 70);
            this.dtpShippingDate.Name = "dtpShippingDate";
            this.dtpShippingDate.Size = new System.Drawing.Size(199, 23);
            this.dtpShippingDate.TabIndex = 81;
            // 
            // lbShippingDate
            // 
            this.lbShippingDate.AutoSize = true;
            this.lbShippingDate.Location = new System.Drawing.Point(387, 73);
            this.lbShippingDate.Name = "lbShippingDate";
            this.lbShippingDate.Size = new System.Drawing.Size(81, 15);
            this.lbShippingDate.TabIndex = 80;
            this.lbShippingDate.Text = "Shipping Date";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(668, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 79;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(572, 525);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 78;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(546, 21);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 77;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(465, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 76;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(396, 22);
            this.txtQuantity.Mask = "00";
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(27, 23);
            this.txtQuantity.TabIndex = 75;
            this.txtQuantity.ValidatingType = typeof(int);
            // 
            // cboProduct
            // 
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(71, 22);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(235, 23);
            this.cboProduct.TabIndex = 74;
            // 
            // dgvDetailList
            // 
            this.dgvDetailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailList.Location = new System.Drawing.Point(12, 254);
            this.dgvDetailList.Name = "dgvDetailList";
            this.dgvDetailList.ReadOnly = true;
            this.dgvDetailList.RowTemplate.Height = 25;
            this.dgvDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailList.Size = new System.Drawing.Size(731, 265);
            this.dgvDetailList.TabIndex = 73;
            this.dgvDetailList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetailList_CellDoubleClick);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(337, 25);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(53, 15);
            this.lbQuantity.TabIndex = 72;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.Location = new System.Drawing.Point(16, 25);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(49, 15);
            this.lbProduct.TabIndex = 71;
            this.lbProduct.Text = "Product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(572, 525);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 93;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbOrderInfo
            // 
            this.gbOrderInfo.Controls.Add(this.lbShippingDateError);
            this.gbOrderInfo.Controls.Add(this.lbCustomerAddressError);
            this.gbOrderInfo.Controls.Add(this.lbCustomerPhoneNumberError);
            this.gbOrderInfo.Controls.Add(this.lbCustomerNameError);
            this.gbOrderInfo.Controls.Add(this.lbShippingMethod);
            this.gbOrderInfo.Controls.Add(this.txtCustomerAddress);
            this.gbOrderInfo.Controls.Add(this.txtOrderPrice);
            this.gbOrderInfo.Controls.Add(this.txtCustomerPhoneNumber);
            this.gbOrderInfo.Controls.Add(this.txtCustomerName);
            this.gbOrderInfo.Controls.Add(this.lbShippingDate);
            this.gbOrderInfo.Controls.Add(this.dtpShippingDate);
            this.gbOrderInfo.Controls.Add(this.rbtnDelivery);
            this.gbOrderInfo.Controls.Add(this.rbtnTakeaway);
            this.gbOrderInfo.Controls.Add(this.lbOrderPrice);
            this.gbOrderInfo.Controls.Add(this.lbCustomerAddress);
            this.gbOrderInfo.Controls.Add(this.lbCustomerPhoneNumber);
            this.gbOrderInfo.Controls.Add(this.lbCustomerName);
            this.gbOrderInfo.Location = new System.Drawing.Point(12, 10);
            this.gbOrderInfo.Name = "gbOrderInfo";
            this.gbOrderInfo.Size = new System.Drawing.Size(731, 159);
            this.gbOrderInfo.TabIndex = 94;
            this.gbOrderInfo.TabStop = false;
            this.gbOrderInfo.Text = "Order details";
            // 
            // lbShippingDateError
            // 
            this.lbShippingDateError.AutoSize = true;
            this.lbShippingDateError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShippingDateError.ForeColor = System.Drawing.Color.Red;
            this.lbShippingDateError.Location = new System.Drawing.Point(509, 96);
            this.lbShippingDateError.Name = "lbShippingDateError";
            this.lbShippingDateError.Size = new System.Drawing.Size(113, 15);
            this.lbShippingDateError.TabIndex = 100;
            this.lbShippingDateError.Text = "lbShippingDateError";
            // 
            // lbCustomerAddressError
            // 
            this.lbCustomerAddressError.AutoSize = true;
            this.lbCustomerAddressError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerAddressError.ForeColor = System.Drawing.Color.Red;
            this.lbCustomerAddressError.Location = new System.Drawing.Point(509, 44);
            this.lbCustomerAddressError.Name = "lbCustomerAddressError";
            this.lbCustomerAddressError.Size = new System.Drawing.Size(136, 15);
            this.lbCustomerAddressError.TabIndex = 99;
            this.lbCustomerAddressError.Text = "lbCustomerAddressError";
            // 
            // lbCustomerPhoneNumberError
            // 
            this.lbCustomerPhoneNumberError.AutoSize = true;
            this.lbCustomerPhoneNumberError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerPhoneNumberError.ForeColor = System.Drawing.Color.Red;
            this.lbCustomerPhoneNumberError.Location = new System.Drawing.Point(119, 96);
            this.lbCustomerPhoneNumberError.Name = "lbCustomerPhoneNumberError";
            this.lbCustomerPhoneNumberError.Size = new System.Drawing.Size(172, 15);
            this.lbCustomerPhoneNumberError.TabIndex = 98;
            this.lbCustomerPhoneNumberError.Text = "lbCustomerPhoneNumberError";
            // 
            // lbCustomerNameError
            // 
            this.lbCustomerNameError.AutoSize = true;
            this.lbCustomerNameError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCustomerNameError.ForeColor = System.Drawing.Color.Red;
            this.lbCustomerNameError.Location = new System.Drawing.Point(119, 44);
            this.lbCustomerNameError.Name = "lbCustomerNameError";
            this.lbCustomerNameError.Size = new System.Drawing.Size(126, 15);
            this.lbCustomerNameError.TabIndex = 97;
            this.lbCustomerNameError.Text = "lbCustomerNameError";
            // 
            // lbShippingMethod
            // 
            this.lbShippingMethod.AutoSize = true;
            this.lbShippingMethod.Location = new System.Drawing.Point(387, 125);
            this.lbShippingMethod.Name = "lbShippingMethod";
            this.lbShippingMethod.Size = new System.Drawing.Size(99, 15);
            this.lbShippingMethod.TabIndex = 92;
            this.lbShippingMethod.Text = "Shipping Method";
            // 
            // gbOrderDetailAction
            // 
            this.gbOrderDetailAction.Controls.Add(this.lbStockError);
            this.gbOrderDetailAction.Controls.Add(this.btnAdd);
            this.gbOrderDetailAction.Controls.Add(this.txtQuantity);
            this.gbOrderDetailAction.Controls.Add(this.cboProduct);
            this.gbOrderDetailAction.Controls.Add(this.lbQuantity);
            this.gbOrderDetailAction.Controls.Add(this.lbProduct);
            this.gbOrderDetailAction.Controls.Add(this.btnRemove);
            this.gbOrderDetailAction.Location = new System.Drawing.Point(62, 175);
            this.gbOrderDetailAction.Name = "gbOrderDetailAction";
            this.gbOrderDetailAction.Size = new System.Drawing.Size(630, 73);
            this.gbOrderDetailAction.TabIndex = 95;
            this.gbOrderDetailAction.TabStop = false;
            // 
            // lbStockError
            // 
            this.lbStockError.AutoSize = true;
            this.lbStockError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStockError.ForeColor = System.Drawing.Color.Red;
            this.lbStockError.Location = new System.Drawing.Point(71, 48);
            this.lbStockError.Name = "lbStockError";
            this.lbStockError.Size = new System.Drawing.Size(71, 15);
            this.lbStockError.TabIndex = 96;
            this.lbStockError.Text = "lbStockError";
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 560);
            this.Controls.Add(this.gbOrderDetailAction);
            this.Controls.Add(this.gbOrderInfo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvDetailList);
            this.Controls.Add(this.txtProductId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewOrder";
            this.Load += new System.EventHandler(this.frmNewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailList)).EndInit();
            this.gbOrderInfo.ResumeLayout(false);
            this.gbOrderInfo.PerformLayout();
            this.gbOrderDetailAction.ResumeLayout(false);
            this.gbOrderDetailAction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtOrderPrice;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.RadioButton rbtnDelivery;
        private System.Windows.Forms.RadioButton rbtnTakeaway;
        private System.Windows.Forms.Label lbOrderPrice;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbCustomerPhoneNumber;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.DateTimePicker dtpShippingDate;
        private System.Windows.Forms.Label lbShippingDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.DataGridView dgvDetailList;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbOrderInfo;
        private System.Windows.Forms.Label lbShippingMethod;
        private System.Windows.Forms.GroupBox gbOrderDetailAction;
        private System.Windows.Forms.Label lbStockError;
        private System.Windows.Forms.Label lbShippingDateError;
        private System.Windows.Forms.Label lbCustomerAddressError;
        private System.Windows.Forms.Label lbCustomerPhoneNumberError;
        private System.Windows.Forms.Label lbCustomerNameError;
    }
}