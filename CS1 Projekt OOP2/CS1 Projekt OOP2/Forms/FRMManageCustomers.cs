using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS1_Projekt_OOP2.Forms
{


    public partial class FRMManageCustomers : Form
    {
        IWarehouse warehouse;
        Customer currentCustomer;
        IEnumerable<Order> activeOrders;
        IEnumerable<Order> archivedOrders;
        Order currentOrder;




        public FRMManageCustomers(IWarehouse wh)
        {
            InitializeComponent();
            warehouse = wh;
            warehouse.WarehouseChanged += UpdateCustomerTable;
            warehouse.WarehouseChanged += UpdateOrderTables;
            UpdateCustomerTable();

            Bitmap bmp = CS1_Projekt_OOP2.Properties.Resources.teamwork;
            this.Icon = Icon.FromHandle(bmp.GetHicon());



            CustomerGridView.RowHeadersVisible = false;
            CustomerGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // CustomerGridView.CellClick += new DataGridViewCellEventHandler(CustomerGridView_CellClick);
            CustomerGridView.EnableHeadersVisualStyles = false;

            ActiveOrdersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArchivedOrdersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

     

        


       


        public void CustomerGridView_CellClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CustomerGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    currentCustomer = warehouse.GetCustomerById((int)row.Cells[0].Value);
                    activeOrders = warehouse.ReturnCustomersActiveOrders(currentCustomer.Number);
                    archivedOrders = warehouse.ReturnCustomersArchivedOrders(currentCustomer.Number);

                    UpdateOrderTables();

                    TXT_editName.Text = currentCustomer.Name;
                    TXT_editPhone.Text = currentCustomer.Phone;
                    TXT_editEmail.Text = currentCustomer.Email;
                    BTN_updateCustomerInfo.Enabled = true;
                }
            }
        }

        //public void UpdateOrderTables()
        //{
        //    ActiveOrdersGridView.Rows.Clear();
        //    ActiveOrdersGridView.Columns.Clear();
            
        //    ArchivedOrdersGridView.Rows.Clear();
        //    ArchivedOrdersGridView.Columns.Clear();


        //    ActiveOrdersGridView.DataSource = activeOrders.ToList();
        //    ArchivedOrdersGridView.DataSource = archivedOrders.ToList();
        //}

        public void UpdateOrderTables()
        {
            ActiveOrdersGridView.Rows.Clear();
            ActiveOrdersGridView.Columns.Clear();

            ActiveOrdersGridView.Columns.Add("Col1", "Number");
            ActiveOrdersGridView.Columns.Add("Col2", "Order date");
            ActiveOrdersGridView.Columns.Add("Col3", "Delivery address");
            ActiveOrdersGridView.Columns.Add("Col4", "Payment completed");
            ActiveOrdersGridView.Columns.Add("Col5", "Refunded");
            ActiveOrdersGridView.Columns.Add("Col6", "Dispatched");

            ArchivedOrdersGridView.Rows.Clear();
            ArchivedOrdersGridView.Columns.Clear();

            ArchivedOrdersGridView.Columns.Add("Col1", "Number");
            ArchivedOrdersGridView.Columns.Add("Col2", "Order date");
            ArchivedOrdersGridView.Columns.Add("Col3", "Delivery address");
            ArchivedOrdersGridView.Columns.Add("Col4", "Payment completed");
            ArchivedOrdersGridView.Columns.Add("Col5", "Refunded");
            ArchivedOrdersGridView.Columns.Add("Col6", "Dispatched");

            if(activeOrders != null)
                foreach (Order o in activeOrders)
                {
                    ActiveOrdersGridView.Rows.Add(o.Number, o.OrderDate, o.DeliveryAddress, o.PaymentCompleted, o.PaymentRefunded, o.Dispatched);
                }

            if(archivedOrders != null)
                foreach (Order o in archivedOrders)
                {
                    ArchivedOrdersGridView.Rows.Add(o.Number, o.OrderDate, o.DeliveryAddress, o.PaymentCompleted, o.PaymentRefunded, o.Dispatched);
                }
        }


        public void UpdateCustomerTable()
        {
            CustomerGridView.Rows.Clear();
            CustomerGridView.Columns.Clear();

            CustomerGridView.Columns.Add("Col1","Id");
            CustomerGridView.Columns.Add("Col2", "Name");
            CustomerGridView.Columns.Add("Col3", "Phone");
            CustomerGridView.Columns.Add("Col4", "Email");
            foreach (Customer c in warehouse.Customers)
            {
                CustomerGridView.Rows.Add(c.Number, c.Name, c.Phone, c.Email);
            }
            
        }

        private void BTN_createNewCustomer_Click(object sender, EventArgs e)
        {
            string newName = TXT_newName.Text;
            string newPhone = TXT_newPhone.Text;
            string newEmail = TXT_newEmail.Text;

            try 
            { 
                warehouse.AddNewCustomer(newName, newPhone, newEmail);
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter name, phone and email.");
            }
            
        }



        private void BTN_updateCustomerInfo_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in CustomerGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    
                    int customerId = int.Parse(row.Cells[0].Value.ToString());
                    string updatedName = TXT_editName.Text;
                    string updatedPhone = TXT_editPhone.Text;
                    string updatedEmail = TXT_editEmail.Text;

                    if(string.IsNullOrEmpty(updatedName)|| string.IsNullOrEmpty(updatedPhone)|| string.IsNullOrEmpty(updatedEmail))
                    {
                        MessageBox.Show("Provide valid information");
                        return;
                    } 

                    try
                    {
                        warehouse.UpdateCustomerInformation(customerId, updatedName, updatedPhone, updatedEmail);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete???
        }

        private void ActiveOrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ActiveOrdersGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    int orderId = (int)row.Cells[0].Value;
                    FRMViewOrder viewOrder = new FRMViewOrder(warehouse.GetOrderById(orderId));
                    viewOrder.Show();
                }
            }
        }

        private void ArchivedOrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in ArchivedOrdersGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    int orderId = (int)row.Cells[0].Value;
                    FRMViewOrder viewOrder = new FRMViewOrder(warehouse.GetOrderById(orderId));
                    viewOrder.Show();
                }
            }
        }
    }
}
