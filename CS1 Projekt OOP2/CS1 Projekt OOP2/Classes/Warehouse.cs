using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

namespace CS1_Projekt_OOP2.Classes
{
    class Warehouse : IWarehouse
    {
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
        public List<Customer> Customers { get; set; }

        public Warehouse()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
            Customers = new List<Customer>();
        }
        public void AddNewCustomer(string _name, string _phone, string _email)
        {
            Customers.Add(new Customer(Customers.Count, _name, _phone, _email));
        }

        public void AddNewOrder(Customer customer, string deliveryAddress, List<OrderLine> orderLines, bool paymentCompleted)
        {
            Orders.Add(new Order(Orders.Count, customer, deliveryAddress, orderLines, paymentCompleted));
        }

        public void AddNewProduct(int code, string name, double price, int stock)
        {
            throw new NotImplementedException();
        }

        //Metod för att uppfylla Order:3
        public void ProcessOrders()
        {
            IEnumerable<Order> readyForDisptach = Orders.Where(a => a.PaymentCompleted == true && a.Items.Any(o => o.Product.Stock < o.Count)).OrderBy(a => a.OrderDate);
            foreach (Order order in readyForDisptach)
            {
                order.Dispatched = true;
                AdjustStock(order.Items);
            }
        }

        public IEnumerable<Order> ReturnUserActiveOrders(int customerID)
        {
            IEnumerable<Order> activeUserOrders = Orders.Where
                (o => o.Dispatched == false
                || o.OrderDate.Subtract(DateTime.Now).TotalDays < 30);
            return activeUserOrders;
        }

        public IEnumerable<Order> ReturnUserArchivedOrders(int customerID)
        {
            IEnumerable<Order> archivedUserOrders = Orders.Where
                (o => o.Dispatched == true
                && o.Customer.Number == customerID
                && o.OrderDate.Subtract(DateTime.Now).TotalDays > 30);
            return archivedUserOrders;
        }

        public IEnumerable<Order> ReturnDispatchedOrders()
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true);
            return dispatchedOrders;
        }

        public IEnumerable<Order> ReturnPendingOrders()
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == false);
            return dispatchedOrders;
        }

        public IEnumerable<Product> ReturnStockZero()
        {
            throw new NotImplementedException();
        }

        public void UpdateProductInformation(string name, double price, int stock)
        {

        }

        public void UpdateCustomerInformation(string name, string phone, string email)
        {

        }

        //Method called when dispatching items. Reduces stock (has already been checked if stock is enough) by the count of the OrderLine.
        public void AdjustStock(List<OrderLine> order)
        {
            foreach (OrderLine orderLine in order)
            {
                orderLine.Product.Stock -= orderLine.Count;
            }
        }
    }
}
