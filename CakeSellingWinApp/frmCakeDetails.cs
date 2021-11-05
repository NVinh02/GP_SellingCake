using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Object;
using DataAccess.Validation;
using DataAccess.Repository;

namespace CakeSellingWinApp
{
    public partial class frmCakeDetails : Form
    {
        public ICakeRepository cakeRepository { get; set; }
        public Cake cakeInfo { get; set; }
        public bool InsertOrUpdate { get; set; }

        //-----------------
        //Update order vars
        public bool OrderUpdate { get; set; }
        public OrderDetail updateOrderDetail { get; set; }
        public IOrderDetailRepository orderDetailRepository { get; set; }
        public int OrderId { get; set; }
        public int CurrentOrderAmount {get; set;}

        //

        public frmCakeDetails()
        {
            InitializeComponent();
        }

        private void frmCakeDetails_Load(object sender, EventArgs e)
        {
            cboCategory.SelectedIndex = 0;
            if (InsertOrUpdate == true)
            {
                lbTitle.Text = "Edit";
                btnConfirm.Text = "Save";
                txtCakeID.Text = cakeInfo.Cakeid.ToString();
                txtCakeName.Text = cakeInfo.Cakename;
                txtPrice.Text = cakeInfo.Price.ToString();
                txtAmount.Text = cakeInfo.Amount.ToString();
                cboCategory.Text = cakeInfo.Category.Trim();
                txtStatus.Text = cakeInfo.Status == true ? "Active" : "Inactive";
            } else
            {
                lbTitle.Text = "Add";
                btnConfirm.Text = "Add";
                lbCakeID.Visible = false;
                txtCakeID.Visible = false;
                lbStatus.Visible = false;
                txtStatus.Visible = false;
            }


        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool Error = true;
            string ID = txtCakeID.Text;
            string Name = txtCakeName.Text;
            string Price = txtPrice.Text;
            string Amount = txtAmount.Text;
            string Category = cboCategory.Text == "Choose cake category" ? "" : cboCategory.Text;
            bool status = txtStatus.Text == "Active" ? true : false;

            if(Validation.checkBlank(Name))
            {
                lbNameError.Text = "Please, fill in cake name";
                Error = false;
            } else if (!Validation.checkCakeName(Name))
            {
                lbNameError.Text = "Cake name have to be 1-100 characters, no special character";
                Error = false;
            } else
            {
                lbNameError.Text = "";
            }

            if (Validation.checkBlank(Price))
            {
                lbPriceError.Text = "Please, fill in cake price";
                Error = false;
            } else 
            if (!Validation.checkDecimalParse(Price))
            {
                lbPriceError.Text = "Price have to be digit. Example: 999.9999";
                Error = false;
            } else if (!Validation.checkCakePrice(decimal.Parse(Price)))
            {
                lbPriceError.Text = "Price can only be 1-10,000,000vnd";
                Error = false;
            } else
            {
                lbPriceError.Text = "";
            }

            if (Validation.checkBlank(Amount))
            {
                lbAmountError.Text = "Please, fill in cake amount";
                Error = false;
            }
            else
            if (!Validation.checkIntegerParse(Amount))
            {
                lbAmountError.Text = "Amount have to be digit. Example: 999";
                Error = false;
            }
            else if (!Validation.checkCakeAmount(int.Parse(Amount)))
            {
                lbAmountError.Text = "Amount can only be 1-1000 cakes";
                Error = false;
            }
            else
            {
                lbAmountError.Text = "";
            }

            if(Validation.checkBlank(Category))
            {
                lbCategoryError.Text = "Please choose a category for this cake";
                Error = false;
            } else
            {
                lbCategoryError.Text = "";
            }

            if (Error)
            {
                try
                {
                    if (InsertOrUpdate)
                    {
                        Cake cake = new Cake
                        {
                            Cakeid = int.Parse(txtCakeID.Text),
                            Cakename = txtCakeName.Text,
                            Price = decimal.Parse(txtPrice.Text),
                            Amount = int.Parse(txtAmount.Text),
                            Category = cboCategory.Text,
                            Status = txtStatus.Text == "Active" ? true : false
                        };
                        cakeRepository.UpdateCake(cake);
                    }
                    else
                    {
                        Cake cake = new Cake
                        {
                            Cakename = txtCakeName.Text,
                            Price = decimal.Parse(txtPrice.Text),
                            Amount = int.Parse(txtAmount.Text),
                            Category = cboCategory.Text,
                            Status = true
                        };
                        cakeRepository.AddNewCake(cake);
                    }
                    this.DialogResult = DialogResult.OK;
                } catch (Exception ex)
                {
                    lbNameError.Text = ex.Message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) => Close();

    }
}
