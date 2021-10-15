using BusinessObject;
using BusinessObject.Object;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        // Intialize membeRepository for function
        public IUserRepository userRepository = new UserRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            User user = userRepository.Login(email, password);
            // active user exists
            if(checkLoginIn(user))
            { 
                string Role = user.Role;
                // user is Admin
                if (Role.Equals("Admin"))
                {
                    frmUserManagement userManagement = new frmUserManagement
                    {
                        loginUser = user
                    };
                    this.Hide();
                    userManagement.ShowDialog();
                    LoadfrmLogin();
                    this.Show();
                } 
                // user is not Admin
                else if (Role.Equals("Staff"))
                {
                    frmUserDetail userDetail = new frmUserDetail
                    {
                        loginUser = user,
                        UserRepo = userRepository,
                        CreateOrUpdate = false,
                        user = user
                    };
                    this.Hide();
                    userDetail.ShowDialog();
                    LoadfrmLogin();
                    this.Show();
                }
            }
        }

        public bool checkLoginIn(User user)
        {
            bool result = false;
            if (user != null && user.Status == true)
            {
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            } else if (user == null)
            {
                MessageBox.Show("User does not exist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (user.Status == false)
            {
                MessageBox.Show("Your Account is banned!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        private void btnExit_Click(object sender, EventArgs e)
        => Close();

        private void LoadfrmLogin()
        {
            txtEmail.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }
    }
}
