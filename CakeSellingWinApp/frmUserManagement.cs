using BusinessObject.Object;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmUserManagement : Form
    {
        public User loginUser { get; set; }
        BindingSource roleSource;
        IUserRepository userRepository = new UserRepository();
        DataTable table = null;
        DataGridViewCellEventArgs EventOfdvgUserList = null;
        public frmUserManagement()
        {
            InitializeComponent();
        }

        // Update member
        private void dvgUserList_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var tempUser = GetUser(e);
            try
            {
                if (tempUser.Role.Equals("Admin") && tempUser.Userid != loginUser.Userid)
                {
                    MessageBox.Show("You shall not update another Admin", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmUserDetail userDetail = new frmUserDetail
                    {
                        loginUser = loginUser,
                        user = GetUser(e),
                        CreateOrUpdate = false, //Insert: true; Update: false
                        UserRepo = userRepository
                    };
                    if (userDetail.ShowDialog() == DialogResult.Cancel)
                    {
                        LoadUserList();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "User Detail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Get User for function Delete
        //Change the text of button Active
        private void dvgUserList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            EventOfdvgUserList = e;
            if (dvgUserList.RowCount > 0)
            {
                var user = GetUser(e);
                if (user.IsEnable == false)
                {
                    btnActive.Text = "Active";
                } else
                {
                    btnActive.Text = "InActive";
                }
            }
        }
        //Load user
        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            btnActive.Enabled = false;
            dvgUserList.CellDoubleClick += dvgUserList_CellDoubleClick_1;
        }
        //Load User
        //Load List of users
        //Load List of users by search result 
        private void LoadUserList(bool search = false, IEnumerable<User> searchDataSource = null)
        {
            IEnumerable<User> users = null;
            try
            {
                // Load user as search
                if (search)
                {
                    table = null;
                    table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Username", typeof(string));
                    table.Columns.Add("Full Name", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Phone Number", typeof(string));
                    table.Columns.Add("Password", typeof(string));
                    table.Columns.Add("Address", typeof(string));
                    table.Columns.Add("Role", typeof(string));
                    table.Columns.Add("Active", typeof(bool));
                    users = searchDataSource;
                    foreach (var user in users)
                    {
                        table.Rows.Add(user.Userid, user.Username, user.Fullname
                            , user.Email, user.Phonenumber, user.Password,
                            user.Address, user.Role, user.IsEnable);
                    }
                    dvgUserList.DataSource = null;
                    dvgUserList.DataSource = table;
                }
                // load user
                else
                {
                    users = userRepository.GetUsers().OrderBy(temp => temp.Role);
                    //get Role list
                    var RoleList = from user in users
                               where (!string.IsNullOrEmpty(user.Role.Trim()))
                               select user.Role;
                    RoleList = RoleList.Prepend("All");
                    RoleList = RoleList.Distinct();
                    if (users.Count() > 0)
                    {
                        roleSource = new BindingSource();
                        roleSource.DataSource = RoleList;
                        cbRole.DataSource = null;
                        cbRole.DataSource = roleSource;
                    }
                    table = null;
                    table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Username", typeof(string));
                    table.Columns.Add("Full Name", typeof(string));
                    table.Columns.Add("Email", typeof(string));
                    table.Columns.Add("Phone Number", typeof(string));
                    table.Columns.Add("Password", typeof(string));
                    table.Columns.Add("Address", typeof(string));
                    table.Columns.Add("Role", typeof(string));
                    table.Columns.Add("Active", typeof(bool));
                    foreach (var user in users)
                    {
                        table.Rows.Add(user.Userid, user.Username, user.Fullname
                            , user.Email, user.Phonenumber, user.Password,
                            user.Address, user.Role, user.IsEnable);
                    }
                    dvgUserList.DataSource = null;
                    dvgUserList.DataSource = table;
                }
                if (users.Count() > 0)
                {
                    btnActive.Enabled = true;
                }
                else
                {
                    btnActive.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Get User
        private User GetUser(DataGridViewCellEventArgs e = null)
        {
            User user = null;
            int index = 0;
            if (e != null)
            {
                try
                {
                    index = e.RowIndex;
                    DataGridViewRow selectRow = dvgUserList.Rows[index];
                    // user is active
                    bool activeChecker = true;
                    //user is banned
                    if (selectRow.Cells[8].Value.ToString().Equals("False"))
                    {
                        activeChecker = false;
                    }
                    user = new User
                    {
                        Userid = int.Parse(selectRow.Cells[0].Value.ToString()),
                        Username = selectRow.Cells[1].Value.ToString(),
                        Fullname = selectRow.Cells[2].Value.ToString(),
                        Email = selectRow.Cells[3].Value.ToString(),
                        Password = selectRow.Cells[4].Value.ToString(),
                        Phonenumber = selectRow.Cells[5].Value.ToString(),
                        Address = selectRow.Cells[6].Value.ToString(),
                        Role = selectRow.Cells[7].Value.ToString(),
                        IsEnable = activeChecker
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Get User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return user;
        }
        //Load User by btn Load
        private void bntLoad_Click(object sender, EventArgs e)
        {
            txtSearchFullName.Text = String.Empty;
            txtSearchUserName.Text = String.Empty;
            LoadUserList();
        }
        //Create new User by btn Create
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmUserDetail userDetail = new frmUserDetail
            {
                Text = "Add a new member",
                CreateOrUpdate = true, //Insert: true, Update: false
                UserRepo = userRepository
            };
            if (userDetail.ShowDialog() == DialogResult.Cancel)
            {
                LoadUserList();
            }
        }
        //Close the form
        private void btnClose_Click(object sender, EventArgs e)
        => Close();
        //Search by the Full name and Username
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool isNullOrEmptySearchFullName = String.IsNullOrEmpty(txtSearchFullName.Text);
            bool isNullOrEmptySearchUserName = String.IsNullOrEmpty(txtSearchUserName.Text);
            if (isNullOrEmptySearchFullName && isNullOrEmptySearchUserName)
            {
               MessageBox.Show("The fields of searching shall be filled in one of them","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                IEnumerable<User> searchDataSource = null;
                if (isNullOrEmptySearchUserName == false
                    && isNullOrEmptySearchFullName == false)
                {
                    using var context = new CakeManagementContext();
                    searchDataSource = context.Users.Where(temp =>
                    temp.Fullname.Trim().ToLower().Contains(txtSearchFullName.Text.Trim().ToLower())
                    && temp.Username.Trim().ToLower().Contains(txtSearchUserName.Text.Trim().ToLower()));
                    if (searchDataSource.Any())
                    {
                        LoadUserList(true, searchDataSource);
                    }
                    else
                    {
                        MessageBox.Show("There is no result matching with full name and username", "Search Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else if (isNullOrEmptySearchFullName == false)
                {
                    using var context = new CakeManagementContext();
                    searchDataSource = context.Users.Where(temp =>
                    temp.Fullname.Trim().ToLower().Contains(txtSearchFullName.Text.Trim().ToLower()));

                    if (searchDataSource.Any())
                    {
                        LoadUserList(true, searchDataSource);
                    }
                    else
                    {
                        MessageBox.Show("There is no result matching with full name", "Search Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    using var context = new CakeManagementContext();
                    searchDataSource = context.Users.Where(temp =>
                    temp.Username.Trim().ToLower().Contains(txtSearchUserName.Text.Trim().ToLower()));
                    if (searchDataSource.Count() > 0)
                    {
                        LoadUserList(true, searchDataSource);
                    }
                    else
                    {
                        MessageBox.Show("There is no result matching with user name", "Load Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        //Search by role
        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbRole.DataSource != null)
                {
                    string role = cbRole.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(role))
                    {
                        if (role.Equals("All"))
                        {
                            LoadUserList();
                        }
                        else
                        {
                            using var context = new CakeManagementContext();
                            IEnumerable<User>searchDataSource = context.Users.Where(temp =>
                            temp.Role.Equals(role));
                            // role exists
                            if (searchDataSource.Any())
                            {
                                LoadUserList(true, searchDataSource);
                            }// role does not exist
                            else
                            {
                                MessageBox.Show("No result matches with role", "Search role", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //(in)active the user
        private void btnActive_Click(object sender, EventArgs e)
        {
            var user = GetUser(EventOfdvgUserList);
            if (user.Userid.Equals(loginUser.Userid))
            {
                MessageBox.Show($"You cannot {btnActive.Text.ToLower()} this {user.Fullname}", $"{btnActive.Text} a user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show($"Do you want to {btnActive.Text.ToLower()} this {user.Fullname}?", $"{btnActive.Text} a user", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        if (btnActive.Text.Equals("Active"))
                        {
                            user.IsEnable = true;
                        } else
                        {
                            user.IsEnable = false;
                        }
                        userRepository.UpdateUser(user);
                        LoadUserList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, $"{btnActive.Text.ToLower()} a user");
                    }
                }
            }
        }
    }
}
