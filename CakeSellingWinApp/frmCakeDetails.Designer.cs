
namespace CakeSellingWinApp
{
    partial class frmCakeDetails
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
            this.lbCakeID = new System.Windows.Forms.Label();
            this.txtCakeID = new System.Windows.Forms.TextBox();
            this.lbCakeName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.txtCakeName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CakeInfoBox = new System.Windows.Forms.GroupBox();
            this.lbCategoryError = new System.Windows.Forms.Label();
            this.lbNameError = new System.Windows.Forms.Label();
            this.lbPriceError = new System.Windows.Forms.Label();
            this.lbAmountError = new System.Windows.Forms.Label();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.CakeInfoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCakeID
            // 
            this.lbCakeID.AutoSize = true;
            this.lbCakeID.Location = new System.Drawing.Point(336, 91);
            this.lbCakeID.Name = "lbCakeID";
            this.lbCakeID.Size = new System.Drawing.Size(18, 15);
            this.lbCakeID.TabIndex = 0;
            this.lbCakeID.Text = "ID";
            // 
            // txtCakeID
            // 
            this.txtCakeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCakeID.Location = new System.Drawing.Point(406, 95);
            this.txtCakeID.Name = "txtCakeID";
            this.txtCakeID.ReadOnly = true;
            this.txtCakeID.Size = new System.Drawing.Size(180, 16);
            this.txtCakeID.TabIndex = 1;
            // 
            // lbCakeName
            // 
            this.lbCakeName.AutoSize = true;
            this.lbCakeName.Location = new System.Drawing.Point(30, 33);
            this.lbCakeName.Name = "lbCakeName";
            this.lbCakeName.Size = new System.Drawing.Size(39, 15);
            this.lbCakeName.TabIndex = 2;
            this.lbCakeName.Text = "Name";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(30, 91);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(33, 15);
            this.lbPrice.TabIndex = 3;
            this.lbPrice.Text = "Price";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(30, 151);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(51, 15);
            this.lbAmount.TabIndex = 4;
            this.lbAmount.Text = "Amount";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(336, 33);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(55, 15);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.Text = "Category";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(336, 155);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(39, 15);
            this.lbStatus.TabIndex = 6;
            this.lbStatus.Text = "Status";
            // 
            // txtCakeName
            // 
            this.txtCakeName.Location = new System.Drawing.Point(100, 30);
            this.txtCakeName.Name = "txtCakeName";
            this.txtCakeName.Size = new System.Drawing.Size(180, 23);
            this.txtCakeName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(100, 88);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(100, 148);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 23);
            this.txtAmount.TabIndex = 9;
            // 
            // txtStatus
            // 
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Location = new System.Drawing.Point(406, 155);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(180, 16);
            this.txtStatus.TabIndex = 11;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Items.AddRange(new object[] {
            "Choose cake category",
            "Desert",
            "Cookie",
            "Cheese Cake"});
            this.cboCategory.Location = new System.Drawing.Point(406, 30);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(180, 23);
            this.cboCategory.TabIndex = 12;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(302, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(50, 25);
            this.lbTitle.TabIndex = 13;
            this.lbTitle.Text = "Title";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(383, 267);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(99, 29);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CakeInfoBox
            // 
            this.CakeInfoBox.Controls.Add(this.lbCategoryError);
            this.CakeInfoBox.Controls.Add(this.lbNameError);
            this.CakeInfoBox.Controls.Add(this.lbPriceError);
            this.CakeInfoBox.Controls.Add(this.lbAmountError);
            this.CakeInfoBox.Controls.Add(this.cboCategory);
            this.CakeInfoBox.Controls.Add(this.txtStatus);
            this.CakeInfoBox.Controls.Add(this.txtAmount);
            this.CakeInfoBox.Controls.Add(this.txtPrice);
            this.CakeInfoBox.Controls.Add(this.txtCakeName);
            this.CakeInfoBox.Controls.Add(this.lbStatus);
            this.CakeInfoBox.Controls.Add(this.lbCategory);
            this.CakeInfoBox.Controls.Add(this.lbAmount);
            this.CakeInfoBox.Controls.Add(this.lbPrice);
            this.CakeInfoBox.Controls.Add(this.lbCakeName);
            this.CakeInfoBox.Controls.Add(this.txtCakeID);
            this.CakeInfoBox.Controls.Add(this.lbCakeID);
            this.CakeInfoBox.Location = new System.Drawing.Point(19, 48);
            this.CakeInfoBox.Name = "CakeInfoBox";
            this.CakeInfoBox.Size = new System.Drawing.Size(609, 213);
            this.CakeInfoBox.TabIndex = 16;
            this.CakeInfoBox.TabStop = false;
            this.CakeInfoBox.Text = "Cake Information";
            // 
            // lbCategoryError
            // 
            this.lbCategoryError.AutoSize = true;
            this.lbCategoryError.ForeColor = System.Drawing.Color.Red;
            this.lbCategoryError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbCategoryError.Location = new System.Drawing.Point(406, 56);
            this.lbCategoryError.Name = "lbCategoryError";
            this.lbCategoryError.Size = new System.Drawing.Size(0, 15);
            this.lbCategoryError.TabIndex = 16;
            // 
            // lbNameError
            // 
            this.lbNameError.AutoSize = true;
            this.lbNameError.ForeColor = System.Drawing.Color.Red;
            this.lbNameError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNameError.Location = new System.Drawing.Point(100, 56);
            this.lbNameError.Name = "lbNameError";
            this.lbNameError.Size = new System.Drawing.Size(0, 15);
            this.lbNameError.TabIndex = 15;
            // 
            // lbPriceError
            // 
            this.lbPriceError.AutoSize = true;
            this.lbPriceError.ForeColor = System.Drawing.Color.Red;
            this.lbPriceError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPriceError.Location = new System.Drawing.Point(100, 114);
            this.lbPriceError.Name = "lbPriceError";
            this.lbPriceError.Size = new System.Drawing.Size(0, 15);
            this.lbPriceError.TabIndex = 14;
            // 
            // lbAmountError
            // 
            this.lbAmountError.AutoSize = true;
            this.lbAmountError.ForeColor = System.Drawing.Color.Red;
            this.lbAmountError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbAmountError.Location = new System.Drawing.Point(100, 174);
            this.lbAmountError.Name = "lbAmountError";
            this.lbAmountError.Size = new System.Drawing.Size(0, 15);
            this.lbAmountError.TabIndex = 13;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(383, 267);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(99, 29);
            this.btnUpdateOrder.TabIndex = 17;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // frmCakeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 325);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.CakeInfoBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCakeDetails";
            this.Text = "frmCakeDetails";
            this.Load += new System.EventHandler(this.frmCakeDetails_Load);
            this.CakeInfoBox.ResumeLayout(false);
            this.CakeInfoBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCakeID;
        private System.Windows.Forms.TextBox txtCakeID;
        private System.Windows.Forms.Label lbCakeName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TextBox txtCakeName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox CakeInfoBox;
        private System.Windows.Forms.Label lbAmountError;
        private System.Windows.Forms.Label lbCategoryError;
        private System.Windows.Forms.Label lbNameError;
        private System.Windows.Forms.Label lbPriceError;
        private System.Windows.Forms.Button btnUpdateOrder;
    }
}