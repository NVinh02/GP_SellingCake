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
        ICakeRepository cakeRepository = new CakeRepository();

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
            openChildForm(new frmCakeList()
            {
                cakeRepository = cakeRepository
            });
        }
    }
}
