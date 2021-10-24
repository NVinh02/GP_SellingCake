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
using BusinessObject.ErrorsObject;
using DataAccess.Validation;

namespace CakeSellingWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Initialized Objects
        // Intialize membeRepository for function
        public IUserRepository userRepository = new UserRepository();
        private UserErrors userErrors = null;
        private IUserValidationRepository validation = new UserValidationReposiroty();
        #endregion

        #region Event
        private void btnCloseApp_Click(object sender, EventArgs e) => Application.Exit();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var tempUser = new User
            {
                Username = username,
                Password = password
            };
            if (checkValidationUser(tempUser))
            {
                User user = userRepository.Login(username, password);
                //active user exists
                if (checkLoginIn(user))
                {
                    string Role = user.Role;
                    // user is Admin
                    if (Role.Equals("Admin"))
                    {
                        frmManagement management = new frmManagement
                        {
                            userInfo = user,
                            userRepository = userRepository
                        };
                        this.Hide();
                        if (management.ShowDialog() == DialogResult.Cancel)
                        {
                            LoadfrmLogin();
                            this.Show();
                        }
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
                        if (userDetail.ShowDialog() == DialogResult.Cancel)
                        {
                            LoadfrmLogin();
                            this.Show();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show($"{userErrors.usernameError}\n{userErrors.passwordError}", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkValidationUser(User user)
        {
            bool result = false;
            userErrors = null;
            userErrors = new UserErrors();
            validation = null;
            validation = new UserValidationReposiroty();
            userErrors.usernameError = validation.checkUserName(user.Username);
            userErrors.passwordError = validation.checkUserPassword(user.Password);
            return result = userErrors.usernameError == null && userErrors.passwordError == null;
        }

        public bool checkLoginIn(User user)
        {
            bool result = false;
            if (user != null && user.Status == true)
            {
                MessageBox.Show("Login Successfully", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = true;
            }
            else if (user == null)
            {
                MessageBox.Show("User does not exist!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (user.Status == false)
            {
                MessageBox.Show("Your Account is banned!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return result;
        }

        private void LoadfrmLogin()
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }
        #endregion

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
