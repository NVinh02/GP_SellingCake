using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeSellingWinApp
{
    public partial class frmOrderCakeDetails : Form
    {
        //Orderid = SelectedOrderID, 
        //                Cakeid = c.Cakeid,
        //                Amount = c.Amount,
        //                Totalprice = c.Amount* original.Price

        public int OrderId { get; set; }
        public int CakeId { get; set; }
        public int Amount { get; set; }
        public decimal TotalPrice { get; set; }

        public frmOrderCakeDetails()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You are an idiot.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmOrderCakeDetails_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = false;
            txtPrice.Enabled = false;
            txtCakeID.Enabled = false;

            txtOrderID.Text = OrderId.ToString();
            txtAmount.Text = Amount.ToString();
            txtPrice.Text = TotalPrice.ToString();
            txtCakeID.Text = CakeId.ToString();
        }
    }
}
