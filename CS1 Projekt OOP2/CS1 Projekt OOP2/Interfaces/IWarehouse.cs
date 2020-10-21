using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2.Interfaces
{
    public interface IWarehouse
    {
        List<Product> Products { get; set; }
        List<Order> Orders { get; set; }
        List<Customer> Customers { get; set; }
        void AddNewOrder(Customer customer, string deliveryAddress, List<OrderLine> orderLines, bool paymentCompleted);
        void ProcessOrders();
        IEnumerable<Order> ReturnDispatchedOrders();
        IEnumerable<Order> ReturnPendingOrders();
        void AddNewCustomer(string name, string phone, string email);
        IEnumerable<Order> ReturnUserArchivedOrders(int customerID);
        IEnumerable<Order> ReturnUserActiveOrders(int customerID);
        void AddNewProduct(int code, string name, double price, int stock);
        IEnumerable<Product> ReturnStockZero();
        void UpdateProductInformation();
        void UpdateCustomerInformation();




    }
}
