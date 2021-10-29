using BusinessObject;
using BusinessObject.Object;
using BusinessObject.ErrorsObject;
using DataAccess.Repository;
using DataAccess.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeSellingWinApp
{
    public partial class frmUserDetail : Form
    {
        public frmUserDetail()
        {
            InitializeComponent();
        }

        #region Initialize Object
        public IUserRepository UserRepo { get; set; }
        public bool CreateOrUpdate { get; set; } //Insert: True; Update: False
        public bool isProfile { get; set; }
        public User user { get; set; }

        public User loginUser { get; set; }
        private UserErrors userErrors = null;
        private IUserValidationRepository validation = new UserValidationRepository();
        #endregion

        #region Event
        private void SizeOfUserDetailForm()
        {
            //Insert
            if (CreateOrUpdate)
            {
                //Insert: true; Update: false
                lbTitle.Text = "Create";
                pnExtraInfo.Visible = false;
                gbUserInfo.Size = new Size { Width = 749, Height = 240 };
            } else
            {
                if (isProfile)
                {
                    pnExtraInfo.Visible = false;
                    lbTitle.Text = "Profile";
                    gbUserInfo.Size = new Size { Width = 749, Height = 240 };
                } else
                {
                    lbTitle.Text = "Update";
                }
            }
        }
        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            SizeOfUserDetailForm();
            LoadUserDetail();
        }
        private void LoadUserDetail()
        {
            // Update
            if (CreateOrUpdate == false)
            {
                txtUserName.Text = user.Username.Trim().ToString();
                txtFullName.Text = user.Fullname.ToString();
                txtEmail.Text = user.Email.Trim().ToString();
                txtPassword.Text = user.Password.Trim().ToString();
                txtPhoneNumber.Text = user.Phonenumber.Trim().ToString();
                txtAddress.Text = user.Address.Trim().ToString();
                lbRoleInformation.Text = user.Role.Trim().ToString();
                lbStatusInformation.Text = user.Status == true? "Active" : "Inactive";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            String role = String.Empty;
            bool status = true;
            checkRoleAndStatus(ref role, ref status);
            try
            {
                checkRedudantString();
                var TempUser = new User
                {
                    Username = txtUserName.Text,
                    Fullname = txtFullName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Phonenumber =txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    Role = role,
                    Status = status,
                };
                if (checkUserDetail(TempUser))
                {
                    //Add a new member
                    if (CreateOrUpdate)
                    {
                        UserRepo.InsertUser(TempUser);
                        MessageBox.Show("Add a new user Successfully!", "Add a new user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } //Update a member 
                    else
                    {
                        TempUser.Userid = user.Userid;
                        UserRepo.UpdateUser(TempUser);
                        MessageBox.Show("Update a user Successfully!", "Update an user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show(userErrors.Display(), CreateOrUpdate == true ? "Add a new member" : "Update a member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadUserDetail();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, CreateOrUpdate == true ? "Add a new member" : "Update a member");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();
        #endregion

        #region check
        private bool checkUserDetail(User tempUser)
        {
            validation = null;
            validation = new UserValidationRepository();
            bool checkDuplicateUserName = true;
            //Insert
            if (CreateOrUpdate)
            {
                if (String.IsNullOrEmpty(tempUser.Username))
                {
                    userErrors = new UserErrors();
                    userErrors.usernameError = "Username is required";
                    return false;
                }
                if ((userErrors = validation.checkUser(tempUser, checkDuplicateUserName)) != null)
                    return false;
            }
            //Update
            else
            {
                string username = user.Username;
                if (username.Equals(tempUser.Username))
                    checkDuplicateUserName = false;
                if ((userErrors = validation.checkUser(user, checkDuplicateUserName)) != null)
                    return false;
            }
            return true;
        }
        public void checkRoleAndStatus(ref string role, ref bool status)
        {
            //Insert
            if (CreateOrUpdate)
            {
                role = "Staff";
                status = true;
            }
            else
            {
                role = lbRoleInformation.Text;
                bool Active = lbStatusInformation.Text.Equals("Active") ? true : false;
                status = Active;
            }
        }
        private void checkRedudantString()
        {
            validation = null;
            validation = new UserValidationRepository();
            txtUserName.Text = validation.checkRedundantWhiteSpace(txtUserName.Text);
            txtFullName.Text = validation.checkRedundantWhiteSpace(txtFullName.Text);
            txtAddress.Text = validation.checkRedundantWhiteSpace(txtAddress.Text);
        }
        #endregion

        #region Key Down
        private void btnSave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
        }
        #endregion
    }
}
