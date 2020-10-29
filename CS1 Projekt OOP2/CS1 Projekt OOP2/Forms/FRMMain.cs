using CS1_Projekt_OOP2.Classes;
using CS1_Projekt_OOP2.Forms;
using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace CS1_Projekt_OOP2
{
    /// <summary>
    /// The root Form which loads at project startup.
    /// </summary>
    public partial class FRMMain : Form
    {
        private IWarehouse warehouse;
        private FRMManageCustomers customerForm;
        private FRMManageProducts productForm;
        private FRMCreateNewOrder newOrderForm;

        /// <summary>
        /// Initializes an instance of the Main Form at project startup.
        /// </summary>
        /// <param name="wh"></param>
        public FRMMain(IWarehouse wh)
        {
            InitializeComponent();
            warehouse = wh;
            wh.WarehouseChanged += UpdateTables;
            wh.WatchNewOrders(this);
            UpdateTables();

            //Setting the form Icon
            Bitmap bmp = CS1_Projekt_OOP2.Properties.Resources.warehouse;
            this.Icon = Icon.FromHandle(bmp.GetHicon());
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {
            PendingOrdersGridView.RowHeadersVisible = false;
            DispatchedOrdersGridView.RowHeadersVisible = false;

            DispatchedOrdersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PendingOrdersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BTNNewOrder_Click(object sender, EventArgs e)
        {
            if (newOrderForm != null)
            {
                newOrderForm.WindowState = FormWindowState.Normal;
                newOrderForm.Focus();
            }
            else
            {
                newOrderForm = new FRMCreateNewOrder(this, warehouse);
                newOrderForm.FormClosed += (o, ea) => newOrderForm = null;
                newOrderForm.Show();
            }
        }

        internal void OpenFRMCustomers ()
        {
        if (customerForm != null)
            {
                customerForm.WindowState = FormWindowState.Normal;
                customerForm.Focus();
            }
            else
            {
                customerForm = new FRMManageCustomers(warehouse);
                customerForm.FormClosed += (o, ea) => customerForm = null;
                customerForm.Show();
            }
        }

        private void BTN_OpenFRMCustomers_Click_1(object sender, EventArgs e)
        {
            OpenFRMCustomers();

        }

        private void BTNProducts_Click(object sender, EventArgs e)
        {
            if (productForm != null)
            {
                productForm.WindowState = FormWindowState.Normal;
                productForm.Focus();
            }
            else
            {
                productForm = new FRMManageProducts(warehouse);
                productForm.FormClosed += (o, ea) => productForm = null;
                productForm.Show();
            }
        }

        private void UpdateTables()
        {

            PendingOrdersGridView.DataSource = warehouse.ReturnPendingOrders().ToList();
            DispatchedOrdersGridView.DataSource = warehouse.ReturnDispatchedOrders().ToList();
            ChangeRowColor();
        }

        private void ChangeRowColor()
        {
            foreach(DataGridViewRow row in DispatchedOrdersGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.LightGray;
            }
        }

        private void PendingOrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in PendingOrdersGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    int orderId = (int)row.Cells[0].Value;
                    FRMViewOrder viewOrder = new FRMViewOrder(warehouse.GetOrderById(orderId), warehouse);
                    viewOrder.Show();
                }
            }
        }

        private void DispatchedOrdersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DispatchedOrdersGridView.SelectedRows)
            {
                if (row.Cells[0].Value != null)
                {
                    int orderId = (int)row.Cells[0].Value;
                    FRMViewOrder viewOrder = new FRMViewOrder(warehouse.GetOrderById(orderId), warehouse);
                    viewOrder.Show();
                }
            }
        }

        private void BTNProcessOrders_Click(object sender, EventArgs e)
        {
            warehouse.ProcessOrders();
        }

    }
}
