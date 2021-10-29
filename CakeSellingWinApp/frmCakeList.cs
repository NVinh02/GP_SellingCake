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
using DataAccess.Repository;
using DataAccess.Validation;

namespace CakeSellingWinApp
{
    public partial class frmCakeList : Form
    {
        private DataTable table = null;
        private IEnumerable<Cake> list = null;
        private int SelectedCakeID;
        private ICakeRepository cakeRepository = new CakeRepository();

        public frmCakeList()
        {
            InitializeComponent();
        }

        private Cake GetSelectedCake()
        {
            Cake cake = null;
            try
            {
                cake = cakeRepository.GetCakeByID(SelectedCakeID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get User");
            }
            return cake;
        }

        private void resetAllComponents()
        {
            txtSearchID.Text = "";
            cboStatusFilter.SelectedIndex = 0;
            dgvCakeList.CellDoubleClick += dgvCakeList_CellDoubleClick;
            list = cakeRepository.GetCakeList(true);
            LoadCakeList();
        }

        private void CleanDataTable()
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Catehory", typeof(string));
            table.Columns.Add("Status", typeof(string));
        }

        private void LoadCakeList()
        {
            try
            {
                CleanDataTable();

                if (list.Count() == 0)
                {
                    lbListStatus.Text = "No result found";
                } else
                {
                    lbListStatus.Text = "";
                }

                foreach (Cake cake in list)
                {
                    table.Rows.Add(cake.Cakeid, cake.Cakename, cake.Price, cake.Amount,
                        cake.Category, cake.Status == true ? "Active" : "Inactive");
                }

                dgvCakeList.DataSource = null;
                dgvCakeList.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load cake list");
            }
        }

        private void frmCakeList_Load(object sender, EventArgs e) => resetAllComponents();

        private void btnReload_Click(object sender, EventArgs e) => resetAllComponents();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCakeDetails details = new frmCakeDetails()
            {
                cakeRepository = cakeRepository,
                InsertOrUpdate = false
            };
            if (details.ShowDialog() == DialogResult.OK)
            {
                if(!txtSearchID.Text.Equals(""))
                {
                    list = cakeRepository.SearchCake(txtSearchID.Text, 
                        txtSearchName.Text,cboStatusFilter.Text=="Active"?true:false);
                } else
                {
                    list = cakeRepository.GetCakeList(cboStatusFilter.Text == "Active" ? true : false);
                }
                LoadCakeList();
            }
        }

        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool status = cboStatusFilter.Text == "Active" ? true : false;
            btnChangeStatus.Text = cboStatusFilter.Text == "Active" ? "Inactive" : "Active";
            list = cakeRepository.GetCakeList(status);
            LoadCakeList();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to {btnChangeStatus.Text.ToLower()} this cake?", $"{btnChangeStatus.Text} a cake", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                bool status = cboStatusFilter.Text == "Active" ? true : false;
                if (status)
                {
                    cakeRepository.InactivateCake(SelectedCakeID);
                }
                else
                {
                    cakeRepository.ActivateCake(SelectedCakeID);
                }
                list = cakeRepository.GetCakeList(status);
                LoadCakeList();
            }
        }

        private void dgvCakeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null)
            {
                int index = e.RowIndex;
                DataGridViewRow selectRow = dgvCakeList.Rows[index];
                SelectedCakeID = int.Parse(selectRow.Cells[0].Value.ToString());
            }
        }

        private void dgvCakeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool status = cboStatusFilter.Text == "Active" ? true : false;
            frmCakeDetails details = new frmCakeDetails
            {
                cakeRepository = cakeRepository,
                cakeInfo = GetSelectedCake(),
                InsertOrUpdate = true
            };
            if (details.ShowDialog() == DialogResult.OK)
            {
                list = cakeRepository.GetCakeList(status);
                LoadCakeList();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ID = txtSearchID.Text;
            string Name = txtSearchName.Text;
            bool status = cboStatusFilter.Text == "Active" ? true : false;

            try
            {
                if (Validation.checkBlank(ID) && Validation.checkBlank(Name))
                {
                    throw new Exception("No key word to search");
                } 
                else if (!Validation.checkIntegerParse(ID) && !Validation.checkBlank(ID))
                {
                    throw new Exception("Incorrect ID");
                }
                else if (!Validation.checkCakeName(Name) && !Validation.checkBlank(Name))
                {
                    throw new Exception("Incorrect name");
                } else
                {
                    lbSearchError.Text = "";
                }

                list = cakeRepository.SearchCake(ID, Name, status);
                
                LoadCakeList();
            }
            catch (Exception ex)
            {
                lbSearchError.Text = ex.Message;
            }
        }
    }
}
