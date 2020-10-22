using CS1_Projekt_OOP2.Interfaces;
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
    public partial class FRMManageCustomers : Form
    {
        IWarehouse warehouse;

        public FRMManageCustomers(IWarehouse wh)
        {
            InitializeComponent();
            warehouse = wh;
            warehouse.WarehouseChanged += UpdateTable;
            UpdateTable();

            CustomerGridView.RowHeadersVisible = false;
            CustomerGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerGridView.CellClick += new DataGridViewCellEventHandler(CustomerGridView_CellClick);

        }

        public void CustomerGridView_CellClick(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in CustomerGridView.SelectedRows)
            {
                if(row.Cells[0].Value != null)
                {
                    TXT_editName.Text = row.Cells[1].Value.ToString();
                    TXT_editPhone.Text = row.Cells[2].Value.ToString();
                    TXT_editEmail.Text = row.Cells[3].Value.ToString();
                }
            }
        }


        public void UpdateTable()
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

            warehouse.AddNewCustomer(newName, newPhone, newEmail);
        }

        private void BTN_updateCustomerInfo_Click(object sender, EventArgs e)
        {
            

            
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
                    warehouse.UpdateCustomerInformation(customerId, updatedName, updatedPhone, updatedEmail);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete???
        }
    }
}
