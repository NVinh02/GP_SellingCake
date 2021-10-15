using BusinessObject;
using BusinessObject.Object;
using DataAccess.Errors;
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

namespace MyStoreWinApp
{
    public partial class frmUserDetail : Form
    {
        public frmUserDetail()
        {
            InitializeComponent();
        }

        // Initialize
        public IUserRepository UserRepo { get; set; }
        public bool CreateOrUpdate { get; set; } //Insert: True; Update: False
        public User user { get; set; }

        public User loginUser { get; set; }
        private ValidationData validation = null;
        private void frmUserDetail_Load(object sender, EventArgs e)
        {
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
                checkLoginUser();
                LoadUserDetail_Role();
                LoadUserDetail_IsEnable();
            }
        }

        private void LoadUserDetail_Role()
        {
            // user is admin
            if (user.Role.Equals("Admin"))
            {
                rbAdmin.Checked = true;
                rbStaff.Checked = false;
            }
            // user is staff
            else
            {
                rbAdmin.Checked = false;
                rbStaff.Checked = true;
            }
        }

        private void LoadUserDetail_IsEnable()
        { 
            //user is enable
            if (user.Status)
            {
                rbYes.Checked = true;
                rbNo.Checked = false;
            }
            // user is banned
            else
            {
                rbNo.Checked = true;
                rbYes.Checked = false;
            }
        }

        private void checkLoginUser()
        {
            if (loginUser.Role.Equals("Admin"))
            {
                pnRole.Enabled = true;
            } else
            {
                pnRole.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool activeChecked = true;
                // if banning the account
                if (rbNo.Checked)
                {
                    activeChecked = false;
                }
                string RoleUser = "Admin";
                // if role is Staff
                if (rbStaff.Checked)
                {
                    RoleUser = "Staff";
                }
                validation = new ValidationData();

                var TempUser = new User
                {
                    Username = txtUserName.Text,
                    Fullname = txtFullName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    Phonenumber =txtPhoneNumber.Text,
                    Address = txtAddress.Text,
                    Role = RoleUser,
                    Status = activeChecked,
                };
                IList<ValidationResult> errors = validation.checkValidUser(user);
                if (errors == null)
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
                    string message = "";
                    foreach (ValidationResult result in errors)
                    {
                        message = message + result.ErrorMessage + "\n";
                    }
                    MessageBox.Show(message.Trim(), CreateOrUpdate == true ? "Add a new member" : "Update a member", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadUserDetail();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, CreateOrUpdate == true ? "Add a new member" : "Update a member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
