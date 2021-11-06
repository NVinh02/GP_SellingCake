using BusinessObject.Object;
using BusinessObject.ErrorsObject;
using DataAccess.Repository;
using System;
using System.Drawing;
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
                btnSave.Text = "Create";
                //cấu hình bên máy Phượng
                gbUserInfo.Size = new Size { Width = 856, Height = 323 };
                //Cấu hình bên máy Vinh
                //gbUserInfo.Size = new Size { Width = 749, Height = 240 };
            } else
            {
                if (isProfile)
                {
                    pnExtraInfo.Visible = false;
                    lbTitle.Text = "Profile";
                    //Cấu hình bên máy Vinh
                    //gbUserInfo.Size = new Size { Width = 749, Height = 240 };
                } else
                {
                    lbTitle.Text = "Update";
                    btnSave.Text = "Save";
                }
            }
        }
        private void frmUserDetail_Load(object sender, EventArgs e)
        {
            // Không hiển thị text của các label error
            ClearLabelError();
            if (loginUser is not null)
            {
                SizeOfUserDetailForm();
                LoadUserDetail();
            }
            else
            {
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmUserDetail_Load(sender, e);
                }
            }
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
        private void ClearLabelError()
        {
            lbUsernameError.Text= String.Empty;
            lbFullnameError.Text= String.Empty;
            lbPasswordError.Text= String.Empty;
            lbPhoneNumberError.Text= String.Empty;
            lbEmailError.Text= String.Empty;
            lbAddressError.Text= String.Empty;
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
                        Close();
                    }
                        
                    //Update a member 
                    else
                    {
                        TempUser.Userid = user.Userid;
                        UserRepo.UpdateUser(TempUser);
                    }
                } 
                else
                    LoadUserDetail();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, CreateOrUpdate == true ? "Add a new member" : "Update a member");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCancel.Text.Equals("Login"))
            {
                frmLogin login = new frmLogin();
                this.Hide();
                login.ShowDialog();
            }
            else
                Close();
        }
        #endregion

        #region check
        //kiểm tra người dùng
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
                    displayError(userErrors);
                    return false;
                }
                if ((userErrors = validation.checkUser(tempUser, checkDuplicateUserName)) != null)
                {
                    displayError(userErrors);
                    return false;
                }
            }
            //Update
            else
            {
                string username = user.Username;
                if (username.Equals(tempUser.Username))
                    checkDuplicateUserName = false;
                if ((userErrors = validation.checkUser(tempUser, checkDuplicateUserName)) != null)
                {
                    displayError(userErrors);
                    return false;
                }
            }
            return true;
        }
        //Hiển thị lỗi khi kiểm tra user
        public void displayError(UserErrors userErrors)
        {
            if (userErrors.checkEmpty(userErrors.usernameError, true))
                lbUsernameError.Text = userErrors.usernameError;
            else
                lbUsernameError.Text = string.Empty;
            if (userErrors.checkEmpty(userErrors.fullnameError, true))
                lbFullnameError.Text = userErrors.fullnameError;
            else
                lbFullnameError.Text = string.Empty;
            if (userErrors.checkEmpty(userErrors.emailError, true))
                lbEmailError.Text = userErrors.emailError;
            else
                lbEmailError.Text = string.Empty;
            if (userErrors.checkEmpty(userErrors.passwordError, true))
                lbPasswordError.Text = userErrors.passwordError;
            else
                lbPasswordError.Text = string.Empty;
            if (userErrors.checkEmpty(userErrors.phonenumberError, true))
                lbPhoneNumberError.Text = userErrors.phonenumberError;
            else
                lbPhoneNumberError.Text = string.Empty;
            if (userErrors.checkEmpty(userErrors.addressError, true))
                lbAddressError.Text = userErrors.addressError;
            else
                lbAddressError.Text = string.Empty;
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
        //xóa đi khoảng trắng dư thừa - username, full name, và address
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
