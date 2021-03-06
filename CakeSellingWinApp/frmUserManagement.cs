using BusinessObject.Object;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CakeSellingWinApp
{
    public partial class frmUserManagement : Form
    {
        #region Initialized Objects
        public User loginUser { get; set; }
        private BindingSource roleSource;
        private IUserRepository userRepository = new UserRepository();
        private DataGridViewCellEventArgs EventOfdvgUserList = null;
        #endregion
        public frmUserManagement()
        {
            InitializeComponent();
            if (loginUser is not null)
                LoadUserList();
        }

        #region Event
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
                if (user != null)
                {
                    if (user.Status == false)
                        btnActive.Text = "Active";
                    else
                        btnActive.Text = "InActive";
                }
            }
        }
        //Load user
        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            lbSearchError.Text = String.Empty;
            lbStatusError.Text = String.Empty;
            if (loginUser is not null)
            {
                LoadUserList();
                dvgUserList.CellDoubleClick += dvgUserList_CellDoubleClick_1;
            }
            else
            {
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmUserManagement_Load(sender, e);
                }
            }
        }
        //Load User
        //Load List of users
        //Load List of users by search result 
        private void LoadUserList(bool search = false, IEnumerable<User> searchDataSource = null)
        {
            IEnumerable<User> users = null;
            DataTable table = null;
            try
            {
                // Load user as search
                if (search)
                {
                    table = setColumnNameOfTable(table);
                    users = searchDataSource;
                    if (users is not null)
                    {
                        foreach (var user in users)
                        {
                            string status = user.Status.ToString();
                            table.Rows.Add(user.Userid, user.Username, user.Fullname
                                , user.Email, user.Phonenumber, user.Password,
                                user.Address, user.Role, status);
                        }
                    }
                }
                // load user
                else
                {
                    table = setColumnNameOfTable(table);
                    users = userRepository.GetUsers().OrderBy(temp => temp.Role);
                    //get Role list
                    var RoleList = new List<String>();
                    RoleList.Add("True");
                    RoleList.Add("False");
                    if (users.Count() > 0)
                    {
                        roleSource = new BindingSource();
                        roleSource.DataSource = RoleList;
                        cbStatus.DataSource = null;
                        cbStatus.DataSource = roleSource;
                    }
                    foreach (var user in users)
                    {
                        if (user.Status)
                        {
                            string status = user.Status.ToString();
                            table.Rows.Add(user.Userid, user.Username, user.Fullname
                                , user.Email, user.Phonenumber, user.Password,
                                user.Address, user.Role, status);
                        }
                    }
                }
                dvgUserList.DataSource = null;
                dvgUserList.DataSource = table;
                btnActive.Enabled = users.Any();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Generating column name of table
        public DataTable setColumnNameOfTable(DataTable table)
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
            table.Columns.Add("Status", typeof(string));
            return table;
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
                        Phonenumber = selectRow.Cells[4].Value.ToString(),
                        Password = selectRow.Cells[5].Value.ToString(),
                        Address = selectRow.Cells[6].Value.ToString(),
                        Role = selectRow.Cells[7].Value.ToString(),
                        Status = activeChecker
                    };
                }
                catch (Exception ex)
                {
                    if (e.RowIndex > 0)
                        MessageBox.Show("You shall not choose empty row", "Get User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return user;
        }
        //Load User by btn Load
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (btnLoad.Text.Equals("Login"))
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();
            } else
            {
                txtSearchFullName.Text = String.Empty;
                txtSearchUserName.Text = String.Empty;
                LoadUserList();
            }
        }
        //Create new User by btn Create
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmUserDetail userDetail = new frmUserDetail
            {
                Text = "Add a new member",
                loginUser = loginUser,
                user = null,
                CreateOrUpdate = true, //Insert: true, Update: false
                UserRepo = userRepository
            };
            if (userDetail.ShowDialog() == DialogResult.Cancel)
            {
                LoadUserList();
            }
        }
        //Search by the Full name and Username
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lbSearchError.Text = String.Empty;
            lbStatusError.Text = String.Empty;
            bool isNullOrEmptySearchFullName = String.IsNullOrEmpty(txtSearchFullName.Text);
            bool isNullOrEmptySearchUserName = String.IsNullOrEmpty(txtSearchUserName.Text);
            if (isNullOrEmptySearchFullName && isNullOrEmptySearchUserName)
            {
                lbSearchError.Text = "No key word to search";
            } else
            {
                IEnumerable<User> searchDataSource = null;
                if (isNullOrEmptySearchUserName == false
                    && isNullOrEmptySearchFullName == false)
                {
                    searchDataSource = userRepository.SearchUserByFullNameAndUserName(txtSearchFullName.Text, txtSearchUserName.Text);
                    if (searchDataSource.Any() == false)
                        lbSearchError.Text = "No matching result";
                }
                else if (isNullOrEmptySearchFullName == false)
                {
                    searchDataSource = searchDataSource = userRepository.SearchUserByFullName(txtSearchFullName.Text);
                    if (searchDataSource.Any() == false)
                        lbSearchError.Text = "No result with full name";
                }
                else
                {
                    searchDataSource = searchDataSource = userRepository.SearchUserByUserName(txtSearchUserName.Text);
                    if (searchDataSource.Any() == false)
                        lbSearchError.Text = "No result with username";
                }
                LoadUserList(true, searchDataSource);
            }
        }

        //Search by role
        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSearchError.Text = String.Empty;
            lbStatusError.Text = String.Empty;
            try
            {
                if (cbStatus.DataSource != null)
                {
                    string status = cbStatus.SelectedItem.ToString();
                    if (!string.IsNullOrEmpty(status))
                    {
                        IEnumerable<User> searchDataSource = userRepository.SearchUserByStatus(status);
                        // status exists
                        if (searchDataSource.Any() == false)
                            lbStatusError.Text = "No result found";
                        LoadUserList(true, searchDataSource);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //(in)active the user
        private void btnActive_Click(object sender, EventArgs e)
        {
            var user = GetUser(EventOfdvgUserList);
            if (user != null)
            {
                if (user.Userid.Equals(loginUser.Userid))
                {
                    MessageBox.Show($"You cannot {btnActive.Text.ToLower()} {user.Fullname}", $"{btnActive.Text} a user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show($"Do you want to {btnActive.Text.ToLower()} {user.Fullname}?", $"{btnActive.Text} a user", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            if (btnActive.Text.Equals("Active"))
                            {
                                user.Status = true;
                            }
                            else
                            {
                                user.Status = false;
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
        #endregion
    }
}
