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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CakeSellingWinApp
{
    public partial class frmNewOrder : Form
    {
        public IOrderRepository orderRepository { get; set; }

        public IOrderDetailRepository orderDetailRepository { get; set; }
        public ICakeRepository cakeRepository { get; set; }
        public bool isAdmin { get; set; } //This is for admin when view this form
        public static int currentUserID = 0; //because the order when created will be bound with the staff that created it
                                             //so i have to throw the user id and user email from the login form to this very form
                                             //i know i can use automapper, but time out for testing data/code flow and stuff lul
        public static string currentUserEmail = ""; //i know that i dont need to use static but im retarded so i used it, my bad lol
        BindingSource source;
        List<OrderDetail> temp = new List<OrderDetail>();
        List<Cake> cakeList = new List<Cake>(); //this is used somewhat like cart in web application
        public decimal price = 0; //this is to save total order money when buying stuff

        //---------------
        //Variables for Update
        public bool InsertOrUpdate = true; //Using this form for both Create and Update 
        //True = Insert | False = Update
        public Order updateOrderInfo { get; set; } //For pull old info when update
        public OrderDetail orderDetails { get; set; }
        public List<Cake> tempCakeList = new List<Cake>();//For load old cake list
        public int SelectedOrderID; //Pulled OrderID from OrderList cell, orderID used throughout update
        private DataTable tableOrderDetail = null;
        private IEnumerable<OrderDetail> listOrderDetails = null;
        //---------------

        /*---------------------------------------------------------------------------------------------------*/
        public frmNewOrder()
        {
            InitializeComponent();
        }

        /*---------------------------------------------------------------------------------------------------*/
        private void frmNewOrder_Load(object sender, EventArgs e)
        {
            if (currentUserID != 0)
            {
                btnCreate.Visible = true;
                btnUpdate.Visible = false;
                clearErrorText();

                var cakes = cakeRepository.GetCakeList(true);
                rbtnTakeaway.Checked = true; //default value for type of order is takeaway
                txtCustomerAddress.Enabled = false;// if takeaway then customer address and shipping date in unvaliable for input
                dtpShippingDate.Enabled = false;
                try
                {

                    //load the cake catalogue and bind it to the binding source
                    source = new BindingSource();
                    source.DataSource = cakes;

                    //bind the cake binding source into the cbo
                    cboProduct.DataSource = null;
                    cboProduct.DataSource = source;

                    //modified how the cbo display
                    cboProduct.DisplayMember = "Cakename"; //display name of the cake
                    cboProduct.ValueMember = "Cakeid"; //but value when take out is the cake id

                    //Check if form is for Create or Update
                    if (!InsertOrUpdate)//Update
                    {
                        btnCreate.Visible = false;
                        btnUpdate.Visible = true;
                        //Load exisiting order info into form
                        //In Update form: Completely disable checkbox Takeaway/Delivery
                        //Locks out Customer address
                        //Locks out shipping date and shipping fee

                        gbOrderDetailAction.Visible = false;
                        rbtnTakeaway.Enabled = false;
                        rbtnDelivery.Enabled = false;
                        dtpShippingDate.Enabled = false;

                        txtCustomerName.Text = updateOrderInfo.Customername.ToString();
                        txtCustomerPhoneNumber.Text = updateOrderInfo.Customerphonenumber.ToString();

                        //Radio button check based on shipping fee
                        if (updateOrderInfo.Shippingfee == 0)
                        {
                            txtCustomerAddress.Enabled = false;
                            rbtnTakeaway.Checked = true;
                            dtpShippingDate.Text = null;
                            dtpShippingDate.Visible = false;
                            lbShippingDate.Visible = false;
                            btnUpdate.Visible = false;
                        }
                        else if (updateOrderInfo.Shippingfee == 30000)
                        {
                            txtCustomerAddress.ReadOnly = true;
                            txtCustomerAddress.Text = updateOrderInfo.Customeraddress;
                            rbtnDelivery.Checked = true;
                            dtpShippingDate.Text = updateOrderInfo.Shippingdate.ToString();
                            dtpShippingDate.Enabled = false;
                            if (isAdmin)
                            {
                                txtCustomerName.ReadOnly = true;
                                txtCustomerPhoneNumber.ReadOnly = true;
                                btnUpdate.Visible = false;
                            }
                        }

                        //Check shipped date
                        if (updateOrderInfo.Shippingdate < DateTime.Now)
                        {
                            lbShippingStatus.Text = "The order has already been shipped.";
                            txtCustomerName.ReadOnly = true;
                            txtCustomerPhoneNumber.ReadOnly = true;
                            btnUpdate.Visible = false;
                        } else
                        {
                            lbShippingStatus.Text = "";
                        }

                        //Load OrderDetails from current order
                        LoadOrderDetailsList();
                    }
                    else
                    {
                        LoadItemList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate ? "Form new Order Load" : "Form Update Order Load");
                }
            } else
            {
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmNewOrder_Load(sender, e);
                }
            }
            
        }

        /*---------------------------------------------------------------------------------------------------*/
        public void clearErrorText()
        {
            lbShippingDateError.Text = string.Empty;
            lbCustomerAddressError.Text = string.Empty;
            lbCustomerNameError.Text = string.Empty;
            lbCustomerPhoneNumberError.Text = string.Empty;
            lbStockError.Text = string.Empty;
        }


        /*---------------------------------------------------------------------------------------------------*/
        //this function is used to recal the total order price when any changes happen to the cart
        public void CalTotalPriceOfOrder()
        {
            txtOrderPrice.Text = string.Empty;//clear the old price
            decimal sum = 0;
            foreach (Cake cake in cakeList)
            {
                sum += cake.Price * cake.Amount;
            }
            if(rbtnDelivery.Checked == true)
            {
                sum = sum + 30000;
            }
            txtOrderPrice.Text = sum.ToString();//update the new price
            price = sum;
        }

        /*---------------------------------------------------------------------------------------------------*/
        //load the item list that has been added to the cart
        public void LoadItemList()
        {
            try
            {
                source = new BindingSource();
                source.DataSource = cakeList;
                txtProductId.DataBindings.Clear();
                txtProductId.DataBindings.Add("Text", source, "Cakeid");
                dgvDetailList.DataSource = null;
                dgvDetailList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Item_Load");
            }
        }

        private void clearDataTable()
        {
            tableOrderDetail = new DataTable();
            tableOrderDetail.Columns.Add("CakeID", typeof(int));
            tableOrderDetail.Columns.Add("CakeName", typeof(string));
            tableOrderDetail.Columns.Add("Price", typeof(decimal));
            tableOrderDetail.Columns.Add("Amount", typeof(int));
            tableOrderDetail.Columns.Add("Category", typeof(string));
        }

        //This is just loading and has yet to be bind
        public void LoadOrderDetailsList()
        {
            try
            {
                clearDataTable();
                listOrderDetails = orderDetailRepository.GetOrderDetailsByOrderID(SelectedOrderID);

                addCakesOfOrderIntoCakeList(listOrderDetails);
                LoadItemList();

                if (listOrderDetails.Count() == 0)
                {
                    MessageBox.Show("Nothing is in order, pleasa add at least 1 cake in order before creating");
                    this.Close();
                }

                //pull: OrderID, CakeID, Amount, TotalPrice
                foreach (OrderDetail orderDetail in listOrderDetails)
                {
                    tableOrderDetail.Rows.Add   (orderDetail.Cakeid,
                                                cakeRepository.GetCakeByID(orderDetail.Cakeid).Cakename,
                                                orderDetail.Totalprice,
                                                orderDetail.Amount,
                                                cakeRepository.GetCakeByID(orderDetail.Cakeid).Category
                                                );
                }

                //source = new BindingSource();
                dgvDetailList.DataSource = null;
                dgvDetailList.DataSource = tableOrderDetail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Function for importing cakes from orderDetail -> CakeList
        public void addCakesOfOrderIntoCakeList(IEnumerable<OrderDetail> listOrderDetails)
        {
            foreach(OrderDetail detail in listOrderDetails)
            {
                Cake temp = cakeRepository.GetCakeByID(detail.Cakeid);

                Cake c = new Cake
                {
                    Cakeid = temp.Cakeid,
                    Cakename = temp.Cakename,
                    Amount = detail.Amount,
                    Price = temp.Price,
                    Category = temp.Category,
                    Status = temp.Status
                };
                cakeList.Add(c);
                CalTotalPriceOfOrder();
            };
        }

        /*---------------------------------------------------------------------------------------------------*/
        //just a bacc button
        private void btnBack_Click(object sender, EventArgs e) => Close();

        /*---------------------------------------------------------------------------------------------------*/
        private void btnAdd_Click(object sender, EventArgs e)
        {
            clearErrorText();

            if (txtQuantity.Text.Equals(""))
            {
                lbStockError.Text = "Please input a quantity number"; //check if the user has left the quantity box blank or not
                return;
            }

            int cakeId = (Int32)cboProduct.SelectedValue; //get the id value from the cbo stuff 
            Cake cake = cakeRepository.GetCakeByID(cakeId); //get the cake that is specified to compare the stock with the quantity user inputted
            int quantity = int.Parse(txtQuantity.Text); //getting the quantity that the user inputted
            if (quantity <= 0)
            {
                lbStockError.Text = "Quantity can not be 0 or a negative number"; //check if the quantity user inputted is not zero or negative
                return;
            }
            if (quantity > cake.Amount) //compare the amount, if all pass then the go further down
            {
                lbStockError.Text = "The amount selected exceed the amount of stock left, stock left: " + cake.Amount;
                return;
            }
            Boolean exist = false; //this is used to check whether or not the product has been in the list/cart

            if (cakeList.Count > 0)
            {
                foreach (Cake pro in cakeList)
                {
                    if (pro.Cakeid == cakeId)
                    {
                        exist = true;
                        break;
                    }
                }
            }

            if (exist) //if the cake already exist in cart we do update
            {
                //Update (delete the old value and add new value in)
                //delete the on currently in list first
                Cake del = new Cake();
                foreach (Cake c in cakeList)
                {
                    if (c.Cakeid == cakeId)
                    {
                        del = c;
                        break;
                    }
                }
                cakeList.Remove(del);
                //then add the new one in
                Cake item = new Cake()
                {
                    Cakeid = cake.Cakeid,
                    Cakename = cake.Cakename,
                    Amount = quantity,
                    Category = cake.Category,
                    Price = cake.Price,
                    Status = cake.Status
                };
                cakeList.Add(item);
                //reload item in the cart
                LoadItemList();
                //display the new total order price after changes
                CalTotalPriceOfOrder();
            }
            else //if the cake has yet to exist within the cart then add new
            {
                //Add new
                Cake item = new Cake()
                {
                    Cakeid = cake.Cakeid,
                    Cakename = cake.Cakename,
                    Amount = quantity,
                    Category = cake.Category,
                    Price = cake.Price,
                    Status = cake.Status
                };
                cakeList.Add(item);
            }

            //reload the item in cart
            LoadItemList();
            //display the new total order price after changes
            CalTotalPriceOfOrder();
        }


        /*---------------------------------------------------------------------------------------------------*/
        private void btnRemove_Click(object sender, EventArgs e)
        {
            clearErrorText();
            Cake del = new Cake();
            foreach (Cake c in cakeList)
            {
                if (c.Cakeid == int.Parse(txtProductId.Text))
                {
                    del = c;
                    break;
                }
            }
            
            cakeList.Remove(del);

            //reload the item in cart
            LoadItemList();
            //display the new total order price after changes
            CalTotalPriceOfOrder();
        }

        /*---------------------------------------------------------------------------------------------------*/
        private void rbtnTakeaway_CheckedChanged(object sender, EventArgs e)
        {
            clearErrorText();
            txtCustomerAddress.Enabled = false;
            dtpShippingDate.Enabled = false;
            CalTotalPriceOfOrder();
        }

        /*---------------------------------------------------------------------------------------------------*/
        private void rbtnDelivery_CheckedChanged(object sender, EventArgs e)
        {
            clearErrorText();
            txtCustomerAddress.Enabled = true;
            dtpShippingDate.Enabled = true;
            CalTotalPriceOfOrder();
        }

        /*---------------------------------------------------------------------------------------------------*/
        private void btnCreate_Click(object sender, EventArgs e)
        {
            bool Error = false;
            clearErrorText();
            //This is to run checking syntax on the customer name
            if (Validation.checkBlank(txtCustomerName.Text))
            {
                lbCustomerNameError.Text = "Name cannot be blank";
                Error = true;
            } else
            if (!Validation.checkCustomerName(txtCustomerName.Text))
            {
                lbCustomerNameError.Text = "Wrong name format";
                Error = true;
            }
            //this is to run checking syntax on the customer phone number 
            if (Validation.checkBlank(txtCustomerPhoneNumber.Text))
            {
                lbCustomerPhoneNumberError.Text = "Phone Number cannot be blank";
                Error = true;
            }
            else
            if (!Validation.checkCustomerPhoneNumber(txtCustomerPhoneNumber.Text))
            {
                lbCustomerPhoneNumberError.Text = "Phone Number can only contain 10 numbers";
                Error = true;
            }
            //if the cakelist/cart has any cake in it or not
            if (cakeList.Count() <= 0)
            {
                lbStockError.Text = "You must have an items to create an order";
                Error = true;
            }
            try
            {
                Order order = null;
                if (rbtnDelivery.Checked == true) //if user choose delivery order
                {
                    //this is to check the customer address
                    if (Validation.checkBlank(txtCustomerAddress.Text))
                    {
                        lbCustomerAddressError.Text = "Address cannot be blank";
                        Error = true;
                    }
                    else
                    if (!Validation.checkCustomerAddress(txtCustomerAddress.Text))
                    {
                        lbCustomerAddressError.Text = "Address is in wrong format";
                        Error = true;
                    }
                    //this is to check whether or not the date for shipping is approriate (not in the past shipping date)
                    //if (DateTime.Parse(dtpShippingDate.Text) < now || now.ToString("dd/MM/yyyy").Equals(dtpShippingDate.Text)
                    //  || now.ToString("MM/dd/yyyy").Equals(dtpShippingDate.Text))
                    DateTime dateTime = Convert.ToDateTime(dtpShippingDate.Value).Date;
                    DateTime Now = DateTime.Today;
                    if (DateTime.Compare(dateTime, Now) == 0 || DateTime.Compare(dateTime, Now) < 0)
                    {
                        lbShippingDateError.Text = "Must be tomorrow or after";
                        Error = true;
                    }
                    if (Error)
                        throw new Exception();
                    order = new Order
                    {
                        Staffid = currentUserID,
                        Totalprice = price,
                        Customername = txtCustomerName.Text,
                        Customeraddress = txtCustomerAddress.Text,
                        Customerphonenumber = txtCustomerPhoneNumber.Text,
                        Shippingdate = DateTime.Parse(dtpShippingDate.Text),
                        Shippingfee = 30000 //shipping fee is always 30k for shipping order

                    };
                }
                if (rbtnTakeaway.Checked == true) //if user choose takeaway order
                {
                    order = new Order
                    {
                        Staffid = currentUserID,
                        Totalprice = price,
                        Customername = txtCustomerName.Text,
                        Customerphonenumber = txtCustomerPhoneNumber.Text,
                        Shippingfee = 0,
                    };
                }
                orderRepository.AddNewOrder(order);//add the new order
                //because we use auto incrememnt for our db, so we have to create first load the list again and 
                //get the last order created just to get the id to bound to the order id field inside order detail
                //when we create it
                var temp = orderRepository.GetOrdersByStaffID(currentUserID); //load order list
                var lastestOrder = temp.Last<Order>(); //get the last one

                foreach (Cake c in cakeList)
                {
                    Cake original = cakeRepository.GetCakeByID(c.Cakeid);// load the original cake currently in the db 
                    //this cake will be use for later 

                    //create the order detail object to add into the db
                    var orderItem = new OrderDetail
                    {
                        Orderid = lastestOrder.Orderid, //this is the orderId value i talk about above
                        Cakeid = c.Cakeid,
                        Amount = c.Amount,
                        Totalprice = c.Amount * original.Price
                    };


                    //the original cake that was load from the db before now is use to compare checking and recal stock
                    var updateCake = new Cake
                    {
                        Cakeid = original.Cakeid,
                        Cakename = original.Cakename,
                        Category = original.Category,
                        Status = original.Status,
                        Price = original.Price,
                        Amount = original.Amount - c.Amount //the recalculate stock part is here 
                    };

                    //run update for the cake
                    cakeRepository.UpdateCake(updateCake);
                    //and add the new order detail item for the order
                    orderDetailRepository.InsertNewOrderDetail(orderItem);
                    this.DialogResult = DialogResult.OK;
                }//the fore each loop will loop until the last item on the cart, this is not really optimal for performance at all lol
            }
            catch (Exception ex)
            {
                return;
            }
        }


        /*---------------------------------------------------------------------------------------------------*/
        //
        //Update & related functions
        //


        //------------------------------------------------------
        //Update button for when update only
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool Error = false;
            clearErrorText();

            //This is to run checking syntax on the customer name
            if (Validation.checkBlank(txtCustomerName.Text))
            {
                lbCustomerNameError.Text = "Name cannot be blank";
                Error = true;
            }
            else
            if (!Validation.checkCustomerName(txtCustomerName.Text))
            {
                lbCustomerNameError.Text = "Wrong name format";
                Error = true;
            }
            //this is to run checking syntax on the customer phone number 
            if (Validation.checkBlank(txtCustomerPhoneNumber.Text))
            {
                lbCustomerPhoneNumberError.Text = "Phone Number cannot be blank";
                Error = true;
            }
            else
            if (!Validation.checkCustomerPhoneNumber(txtCustomerPhoneNumber.Text))
            {
                lbCustomerPhoneNumberError.Text = "Phone Number can only contain 10 numbers";
                Error = true;
            }
            //if the cakelist/cart has any cake in it or not
            if (cakeList.Count() <= 0)
            {
                lbStockError.Text = "You must have an items to create an order";
                Error = true;
            }
            //---------
            try
            {
                Order orderUpdate = null;

                if (updateOrderInfo.Shippingfee == 30000) //if user choose delivery order
                {
                    //this is to check the customer address
                    if (Validation.checkBlank(txtCustomerAddress.Text))
                    {
                        lbCustomerAddressError.Text = "Address cannot be blank";
                        Error = true;
                    }
                    else
                    if (!Validation.checkCustomerAddress(txtCustomerAddress.Text))
                    {
                        lbCustomerAddressError.Text = "Customer Address is in wrong format";
                    }
                    DateTime now = DateTime.Today;
                    //this is to check whether or not the date for shipping is approriate (not in the past shipping date)
                    if (DateTime.Parse(dtpShippingDate.Text) < now || now.ToString("dd/MM/yyyy").Equals(dtpShippingDate.Text))
                    {
                        lbShippingDateError.Text = "Shipping Date must be tomorrow or after";
                        Error = true;
                    }
                    if (Error)
                        throw new Exception();
                    orderUpdate = new Order
                    {
                        Orderid = SelectedOrderID,
                        Staffid = currentUserID,
                        Totalprice = price,
                        Customername = txtCustomerName.Text,
                        Customerphonenumber = txtCustomerPhoneNumber.Text,
                        Customeraddress = txtCustomerAddress.Text,
                        Createddate = updateOrderInfo.Createddate,
                        Shippingdate = DateTime.Parse(dtpShippingDate.Text),
                        Shippingfee = 30000 //shipping fee is always 30k for shipping order
                    };
                }
                if (updateOrderInfo.Shippingfee == 0) //if user choose takeaway order
                {
                    orderUpdate = new Order
                    {
                        Orderid = SelectedOrderID,
                        Staffid = currentUserID,
                        Totalprice = price,
                        Customername = txtCustomerName.Text,
                        Customerphonenumber = txtCustomerPhoneNumber.Text,
                        Customeraddress = updateOrderInfo.Customeraddress,
                        Createddate = updateOrderInfo.Createddate,
                        Shippingdate = DateTime.Parse(dtpShippingDate.Text),
                        Shippingfee = 0
                    };
                }

                //Update order
                orderRepository.UpdateOrder(orderUpdate);

                //Update Cake in Repo after udpate order
                foreach (Cake c in cakeList)
                {
                    Cake original = cakeRepository.GetCakeByID(c.Cakeid);// load the original cake currently in the db 
                    //this cake will be use for later 

                    //create the order detail object to add into the db
                    var orderItem = new OrderDetail
                    {
                        Orderid = SelectedOrderID,
                        Cakeid = c.Cakeid,
                        Amount = c.Amount,
                        Totalprice = c.Amount * original.Price
                    };

                    //the original cake that was load from the db before now is use to compare checking and recal stock
                    var updateCake = new Cake
                    {
                        Cakeid = original.Cakeid,
                        Cakename = original.Cakename,
                        Category = original.Category,
                        Status = original.Status,
                        Price = original.Price,
                        Amount = original.Amount - c.Amount //the recalculate stock part is here 
                    };


                    cakeRepository.UpdateCake(updateCake);
                    //run update for the cake

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

    }
}
