using BusinessObject.Object;
using DataAccess.Errors;
using DataAccess.Repository;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private ValidationData userValidation = new ValidationData();
        private ValidationData validation = null;
        private UserErrors userErrors = null;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            validation = new ValidationData();
            userErrors = new UserErrors();
            userErrors.usernameError = validation.CheckStringType("username", username, true, 1, 50, @"^[A-Za-z0-9]*$");
            userErrors.passwordError = validation.CheckStringType("password", password, true, 3, 30, @"^[^\s]+$");
            if (userErrors.usernameError == null && userErrors.passwordError == null)
            {
                User user = userRepository.Login(username, password);
                //active user exists
                if (checkLoginIn(user))
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
            else
            {
                MessageBox.Show($"{userErrors.usernameError}\n{userErrors.passwordError}", "Login", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }
    }
}
