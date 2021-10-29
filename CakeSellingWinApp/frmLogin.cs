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
        private IUserValidationRepository validation = new UserValidationRepository();
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
                    frmManagement management = new frmManagement
                    {
                        userInfo = user
                    };
                    this.Hide();
                    if (management.ShowDialog() == DialogResult.Cancel)
                    {
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

        private bool checkValidationUser(User user)
        {
            bool result = false;
            userErrors = null;
            userErrors = new UserErrors();
            validation = null;
            validation = new UserValidationRepository();
            userErrors.usernameError = validation.checkUserName(user.Username);
            userErrors.passwordError = validation.checkUserPassword(user.Password);
            return result = userErrors.usernameError == null && userErrors.passwordError == null;
        }

        public bool checkLoginIn(User user)
        {
            bool result = false;
            if (user != null && user.Status == true)
            {
                lbLoginStatus.Text = "Login Success";
                result = true;
            }
            else if (user == null)
            {
                lbLoginStatus.Text = "Wrong username or password";
            }
            else if (user.Status == false)
            {
                lbLoginStatus.Text = "Your account have been banned!";
            }
            return result;
        }

        private void LoadfrmLogin()
        {
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            lbLoginStatus.Text = String.Empty;
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
