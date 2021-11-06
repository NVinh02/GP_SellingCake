using BusinessObject.Object;
using DataAccess.Validation;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeSellingWinApp
{
    public partial class frmOrderList : Form
    {
        IOrderRepository orderRepository = new OrderRepository();
        ICakeRepository cakeRepository = new CakeRepository();
        IUserRepository userRepository = new UserRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();
        public User staff { get; set; }
        private DataTable table = null;
        private IEnumerable<Order> list = null;
        private int SelectedOrderID = 0;
        public frmOrderList()
        {
            InitializeComponent();
        }

        private void CleanDataTable()
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            if (staff.Role.Equals("Admin"))
            table.Columns.Add("StaffID", typeof(int));
            table.Columns.Add("Price", typeof(decimal));
            table.Columns.Add("Customer Name", typeof(string));
            table.Columns.Add("Customer Address", typeof(string));
            table.Columns.Add("Customer PhoneNumber", typeof(string));
            table.Columns.Add("ShippingFee", typeof(decimal));
            table.Columns.Add("Ordered Date", typeof(DateTime));
            table.Columns.Add("Shipped Date", typeof(DateTime));

        }

        private void resetAllComponents()
        {
            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            clearErrorText();
            if (staff.Role.Equals("Admin"))
            {
                list = orderRepository.GetOrderList().Reverse();
                btnNew.Visible = false;
            }
            else
                list = orderRepository.GetOrdersByStaffID(staff.Userid).Reverse();
            LoadOrderList();
        }
        private void clearErrorText()
        {
            lbSearchIDError.Text = string.Empty;
            lbCustomerSearchError.Text = string.Empty;
        }

        private void LoadOrderList()
        {
            try
            {
                CleanDataTable();

                if (list.Count() == 0)
                {
                    lbListStatus.Text = "No result found";
                }
                else
                {
                    lbListStatus.Text = "";
                }

                foreach (Order order in list)
                {
                    if (staff.Role.Equals("Admin"))
                        table.Rows.Add(order.Orderid,
                        order.Staffid,
                        order.Totalprice,
                        order.Customername,
                        order.Customeraddress,
                        order.Customerphonenumber,
                        order.Shippingfee,
                        order.Createddate,
                        order.Shippingdate);
                    else
                        table.Rows.Add(order.Orderid,
                        order.Totalprice,
                        order.Customername,
                        order.Customeraddress,
                        order.Customerphonenumber,
                        order.Shippingfee,
                        order.Createddate,
                        order.Shippingdate);
                }

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        private void frmOrderList_Load(object sender, EventArgs e)
        {
            if (staff is not null)
            {
                resetAllComponents();
            } else
            {
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmOrderList_Load(sender, e);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e) => resetAllComponents();

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearErrorText();
            frmNewOrder newOrder = new frmNewOrder
            {
                Text = "New Order",
                orderRepository = orderRepository,
                orderDetailRepository = orderDetailRepository,
                cakeRepository = cakeRepository
            };
            frmNewOrder.currentUserEmail = staff.Email;
            frmNewOrder.currentUserID = staff.Userid;
            //newOrder.Show();
            if (newOrder.ShowDialog() == DialogResult.OK)
            {
                list = orderRepository.GetOrdersByStaffID(staff.Userid).Reverse();
                LoadOrderList();
            }
        }

        private void btnFilterDeliveryOrder_Click(object sender, EventArgs e)
        {
            clearErrorText();
            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            CleanDataTable();
            list = null;
            if (staff.Role.Equals("Admin"))
                list = orderRepository.GetDeliveryOrderList().Reverse();
            else
                list = orderRepository.GetDeliveryOrderListByStaffID(staff.Userid).Reverse();
            LoadOrderList();
        }

        private void btnTakewayOrder_Click(object sender, EventArgs e)
        {
            clearErrorText();
            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            txtOrderID.Text = string.Empty;
            CleanDataTable();
            list = null;
            if (staff.Role.Equals("Admin"))
                list = orderRepository.GetTakeawaytOrderList().Reverse();
            else
                list = orderRepository.GetTakeawaytOrderListByStaffId(staff.Userid).Reverse();
            LoadOrderList();
        }

        private void btnSearchOrderID_Click(object sender, EventArgs e)
        {
            List<Order> tmp = new List<Order>();
            txtCustomerName.Text = string.Empty;
            txtCustomerPhone.Text = string.Empty;
            clearErrorText();
            //validation for input
            if (Validation.checkBlank(txtOrderID.Text))
            {
                lbSearchIDError.Text="Not allow blank";
                return;
            }

            Regex regex = new Regex(@"[0-9]+[-]{0,1}$");
            if (!regex.IsMatch(txtOrderID.Text))
            {
                lbSearchIDError.Text="Number only";
                return;
            }

            int orderID = int.Parse(txtOrderID.Text);
            if (orderID <= 0)
            {
                lbSearchIDError.Text="Not allow 0 or negative";
                return;
            }

            //clean the datetable and load the new data on it
            CleanDataTable();
            list = null;
            if (staff.Role.Equals("Admin")) {

                tmp.Add(orderRepository.GetOrderByID(orderID));
                list = tmp;
            }
            else
                list = orderRepository.GetOrderListByIDAndStaffID(orderID, staff.Userid);
            LoadOrderList();
        }

        /*---------------------------------------------------------------------------------------------------*/
        //---------------
        //For Update Function
        private Order getSelectedOrder()
        {
            Order order = null;
            try
            {
                order = orderRepository.GetOrderByID(SelectedOrderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return order;
        }


    //Get Order from table cell
    private void dgvOrderList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e != null)
            {
                int index = e.RowIndex;
                if (index <= -1)
                {
                    //Do nothing.
                }
                else {
                    DataGridViewRow selectRow = dgvOrderList.Rows[index];
                    SelectedOrderID = int.Parse(selectRow.Cells[0].Value.ToString());
                }
            }

            Order order = getSelectedOrder();
            bool isAdmin = staff.Role == "Admin" ? true : false;
            //Call to frmNewOrder for Update
            frmNewOrder frmNewOrder = new frmNewOrder
            {
                InsertOrUpdate = false,
                Text = "Update Order",
                orderRepository = orderRepository,
                orderDetailRepository = orderDetailRepository,
                cakeRepository = cakeRepository,
                updateOrderInfo = order,
                SelectedOrderID = SelectedOrderID,
                isAdmin = isAdmin
            };

            //Email & ID from current logged in user
            frmNewOrder.currentUserEmail = staff.Email;
            frmNewOrder.currentUserID = staff.Userid;
            //frmNewOrder.Show();
            if (frmNewOrder.ShowDialog() == DialogResult.OK)
            {
                list = orderRepository.GetOrdersByStaffID(staff.Userid).Reverse();
                LoadOrderList();
            }
        }

        private void btnSearchCustomerNameAndPhone_Click(object sender, EventArgs e)
        {
            try
            {
                clearErrorText();
                if (Validation.checkBlank(txtCustomerName.Text) && Validation.checkBlank(txtCustomerPhone.Text))
                {
                    lbCustomerSearchError.Text = "Need more information`";
                }
                else
                {
                    if (staff.Role.Equals("Admin"))
                        list = orderRepository.GetOrdersByEitherCustomerNameOrPhoneOrBoth(txtCustomerPhone.Text, txtCustomerName.Text);
                    else
                        list = orderRepository.GetOrdersByEitherCustomerNameOrPhoneOrBothBasedOnStaffId(txtCustomerPhone.Text, txtCustomerName.Text, staff.Userid);
                    LoadOrderList();
                }
            }
            catch (Exception ex)
            {
                //idk what error to put here to just catch it to be sure 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
