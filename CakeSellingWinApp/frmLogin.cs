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
    public partial class frmLogin : Form
    {
        IUserRepository userRepository = new UserRepository();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCloseApp_Click(object sender, EventArgs e) => Application.Exit();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var user = userRepository.CheckLogin(username, password);

            if (user != null)
            {

                frmManagement manager = new frmManagement();
                this.Hide();
                if (manager.ShowDialog() == DialogResult.Cancel)
                {
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    this.Show();
                }
            }
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

            }
        }
    }
}
