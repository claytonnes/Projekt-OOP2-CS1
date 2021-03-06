﻿using CS1_Projekt_OOP2.Interfaces;
using System;
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

    /// <summary>
    /// Form class which enables a GUI to view Order information.
    /// </summary>
    public partial class FRMViewOrder : Form
    {
        IWarehouse warehouse;
        Order order; 

        /// <summary>
        /// Initializes an instance of the ViewOrder Form.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="warehouse"></param>
        public FRMViewOrder(Order o, IWarehouse warehouse)
        {
            InitializeComponent();

            order = o;
            this.warehouse = warehouse;
            UpdateLabels();
            UpdateItemList();
            warehouse.WarehouseChanged += UpdateLabels;

            //Setting the form Icon
            Bitmap bmp = CS1_Projekt_OOP2.Properties.Resources.checklist;
            this.Icon = Icon.FromHandle(bmp.GetHicon());

            //Configures the form's datagridview.
            ItemListGridView.RowHeadersVisible = false;
            ItemListGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void UpdateLabels()
        {
            LBL_customerId.Text = order.Customer.Number.ToString();
            LBL_customerName.Text = order.Customer.Name;
            LBL_customerPhone.Text = order.Customer.Phone;
            LBL_customerEmail.Text = order.Customer.Email;
            LBL_deliveryAdress.Text = order.DeliveryAddress;
            LBL_orderNumber.Text = order.Number.ToString();

            if (warehouse.TryOrderProducts(order))
                LBL_earliestDispatch.Text = warehouse.GetEarliestDispatchTime(order.Number).ToString();
            else LBL_earliestDispatch.Text = "N/A";
           LBL_orderNumber.Text = order.Number.ToString();

            LBL_orderDate.Text = order.OrderDate.ToString();
            LBL_paymentCompleted.Text = GetStyledStatusValue(LBL_paymentCompleted, order.PaymentCompleted);
            LBL_paymentRefunded.Text = GetStyledStatusValue(LBL_paymentRefunded, order.PaymentRefunded);
            LBL_dispatched.Text = GetStyledStatusValue(LBL_dispatched, order.Dispatched);
        }

        private string GetStyledStatusValue(Label label, bool value)
        {
            string status;
            label.ForeColor = value ? Color.Green : Color.Red;

            switch(label.Name)
            {
                case "LBL_paymentCompleted":
                    status = value ? "Paid" : "NOT paid";
                    return status;
                case "LBL_paymentRefunded":
                    status = value ? "Refunded" : "NOT refunded";
                    return status;
                case "LBL_dispatched":
                    status = value ? "Dispatched" : "NOT dispatched";
                    return status;


                default:
                    return "Error!";
            }

        }

        private void UpdateItemList()
        {
            ItemListGridView.Rows.Clear();
            ItemListGridView.Columns.Add("Col1", "Product");
            ItemListGridView.Columns.Add("Col2", "Amount");
            ItemListGridView.Columns.Add("Col3", "Currently in stock:");
            ItemListGridView.Columns.Add("Col4", "Next Restocking:");
            ItemListGridView.Columns.Add("Col5", "First Available");
            if(warehouse.TryOrderProducts(order))
                foreach (OrderLine ol in order.Items)
                {
                    ItemListGridView.Rows.Add(ol.Product.Name, ol.Count, ol.Product.Stock, ol.Product.NextStocking, ol.Product.FirstAvailable);
                }
        }      
    }
}
