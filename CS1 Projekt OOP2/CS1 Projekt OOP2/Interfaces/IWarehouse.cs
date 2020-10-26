using CS1_Projekt_OOP2.Classes;
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


        event ChangeHandler WarehouseChanged;
        void RaiseWarehouseChanged();

        void ProcessOrders();


        Order GetOrderById(int id);
        void AddNewOrder(Customer customer, string deliveryAddress, List<OrderLine> orderLines, bool paymentCompleted);
        IEnumerable<Order> ReturnDispatchedOrders();
        IEnumerable<Order> ReturnPendingOrders();



        Customer  GetCustomerById(int id);
        void AddNewCustomer(string name, string phone, string email);
        void UpdateCustomerInformation(int id, string name, string phone, string email);
        IEnumerable<Order> ReturnCustomersArchivedOrders(int customerID);
        IEnumerable<Order> ReturnCustomersActiveOrders(int customerID);


        Product GetProductById(int id);
        void AddNewProduct(string name, double price, int stock);
        void UpdateProductInformation(int id, string name, double price, int stock);
        IEnumerable<Product> ReturnAllProductsWithZeroStock();
        Order AdjustOrder(Order o);




    }
}
