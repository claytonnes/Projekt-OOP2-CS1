using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2.Interfaces
{
    interface IWarehouse
    {
        List<Product> Products { get; set; }
        List<Order> Orders { get; set; }
        List<Customer> Customers { get; set; }
        void AddNewOrder(List<OrderLine> orderLines, Customer customer, string deliveryAddress);
        void ProcessOrders();
        IEnumerable<Order> ReturnDispatchedOrders();
        IEnumerable<Order> ReturnPendingOrders();
        void AddNewCustomer();
        void UpdateCustomerName(int id, string name);
        void UpdateCustomerPhone(int id, string phone);
        void UpdateCustomerEmail(int id, string email);
        IEnumerable<Order> ReturnArchivedOrders(int customerID);
        IEnumerable<Order> ReturnActiveOrders(int customerID);
        void AddNewProduct(int code, string name, double price, int stock);
        void UpdateProductName(int code, string name);
        void UpdateProductPrice(int code, double price);
        void UpdateProductStock(int code, int stock);
        IEnumerable<Product> ReturnStockZero();


        
    }
}
