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
            // user exists
            if(user != null)
            { 
                string Role = user.Role;
                bool IsEnable = user.IsEnable;
                // user is Admin
                if (Role.Equals("Admin"))
                {
                    MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (IsEnable)
                    {
                        MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    } else
                    {
                        MessageBox.Show("Your Account is banned by Manager!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                    }
                }
            }
            //member does not exist
            else
            {
                if (MessageBox.Show("Login Failed","Login",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
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
