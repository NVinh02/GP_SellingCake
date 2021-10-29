
namespace CakeSellingWinApp
{
    partial class frmOrderCakeDetails
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
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbCakeID = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtCakeID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(25, 28);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(51, 15);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "Order ID";
            // 
            // lbCakeID
            // 
            this.lbCakeID.AutoSize = true;
            this.lbCakeID.Location = new System.Drawing.Point(25, 57);
            this.lbCakeID.Name = "lbCakeID";
            this.lbCakeID.Size = new System.Drawing.Size(47, 15);
            this.lbCakeID.TabIndex = 1;
            this.lbCakeID.Text = "Cake ID";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(25, 89);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(51, 15);
            this.lbAmount.TabIndex = 2;
            this.lbAmount.Text = "Amount";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(25, 124);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(33, 15);
            this.lbTotalPrice.TabIndex = 3;
            this.lbTotalPrice.Text = "Price";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(92, 28);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(140, 23);
            this.txtOrderID.TabIndex = 4;
            // 
            // txtCakeID
            // 
            this.txtCakeID.Location = new System.Drawing.Point(92, 57);
            this.txtCakeID.Name = "txtCakeID";
            this.txtCakeID.Size = new System.Drawing.Size(140, 23);
            this.txtCakeID.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(92, 89);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(140, 23);
            this.txtAmount.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(92, 124);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 23);
            this.txtPrice.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(135, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(25, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmOrderCakeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 210);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtCakeID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.lbCakeID);
            this.Controls.Add(this.lbOrderID);
            this.Name = "frmOrderCakeDetails";
            this.Text = "frmOrderCakeDetails";
            this.Load += new System.EventHandler(this.frmOrderCakeDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbCakeID;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCakeID;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
    }
}