using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2.Classes
{
    class Warehouse : IWarehouse
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }

        public void AddNewCustomer()
        {
            throw new NotImplementedException();
        }

        public void AddNewOrder()
        {
            throw new NotImplementedException();
        }

        public void AddNewOrder(List<OrderLine> orderLines, Customer customer, string deliveryAddress)
        {
            throw new NotImplementedException();
        }

        public void AddNewProduct(int code, string name, double price, int stock)
        {
            throw new NotImplementedException();
        }

        public void ProcessOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnActiveOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnActiveOrders(int customerID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnArchivedOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnArchivedOrders(int customerID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnDispatchedOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> ReturnPendingOrders()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> ReturnStockZero()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerEmail(int id, string email)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerInformation(int customerID)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerName(int id, string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerPhone(int id, string phone)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductName(int code, string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductPrice(int code, double price)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductStock(int code, int stock)
        {
            throw new NotImplementedException();
        }
    }
}
