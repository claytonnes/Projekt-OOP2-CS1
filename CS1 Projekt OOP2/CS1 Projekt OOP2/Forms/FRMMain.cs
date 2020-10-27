﻿using CS1_Projekt_OOP2.Classes;
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
    public partial class FRMMain : Form
    {
        private IWarehouse wh;
        private FRMManageCustomers customerForm;
        private FRMManageProducts productForm;
        private FRMCreateNewOrder newOrderForm;

        public FRMMain(IWarehouse wh)
        {
            InitializeComponent();
            this.wh = wh;
            wh.WarehouseChanged += UpdateTables;
            wh.WatchNewOrders(this);
            UpdateTables();
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
                newOrderForm = new FRMCreateNewOrder(this, wh);
                newOrderForm.FormClosed += (o, ea) => newOrderForm = null;
                newOrderForm.Show();
            }
        }

        public void OpenFRMCustomers ()
        {
        if (customerForm != null)
            {
                customerForm.WindowState = FormWindowState.Normal;
                customerForm.Focus();
            }
            else
            {
                customerForm = new FRMManageCustomers(wh);
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
                productForm = new FRMManageProducts(wh);
                productForm.FormClosed += (o, ea) => productForm = null;
                productForm.Show();
            }
        }

        private void UpdateTables()
        {

            PendingOrdersGridView.DataSource = wh.ReturnPendingOrders().ToList();
            DispatchedOrdersGridView.DataSource = wh.ReturnDispatchedOrders().ToList();
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
                    FRMViewOrder viewOrder = new FRMViewOrder(wh.GetOrderById(orderId), wh);
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
                    FRMViewOrder viewOrder = new FRMViewOrder(wh.GetOrderById(orderId), wh);
                    viewOrder.Show();
                }
            }
        }

        private void BTNProcessOrders_Click(object sender, EventArgs e)
        {
            wh.ProcessOrders();
        }

    }
}
