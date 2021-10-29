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

namespace CakeSellingWinApp
{
    public partial class frmManagement : Form
    {
        public User userInfo { get; set; }
        private IUserRepository userRepository = new UserRepository();

        public frmManagement()
        {
            InitializeComponent();
        }

        private Form activeChildForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }
            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDisplayer.Controls.Add(childForm);
            panelDisplayer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e) => Close();

        private void btnCakeList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCakeList());
        }

        private void btnStaffList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserManagement
            {
                loginUser = userInfo
            });
        }

        private void btnOrderList_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrderList
            {
                staff = userInfo
            });
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            openChildForm(new frmOrderList
            {
                staff = userInfo
            });
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {
            if (userInfo.Role.Equals("Admin"))
            {
                btnOrder.Visible = false;
            } else
            {
                btnCakeList.Visible = false;
                btnOrderList.Visible = false;
                btnStaffList.Visible = false;
            }
            lbWelcome.Text = "Welcome " + userInfo.Fullname;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserDetail
            {
                user = userInfo,
                UserRepo = userRepository,
                CreateOrUpdate = false,
                isProfile = true
            });
        }
    }
}
