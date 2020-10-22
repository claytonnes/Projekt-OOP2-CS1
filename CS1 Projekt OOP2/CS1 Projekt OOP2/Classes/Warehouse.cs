using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2.Classes
{

    public delegate void ChangeHandler();

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

        public event ChangeHandler WarehouseChanged;

        public void RaiseWarehouseChanged()
        {
            WarehouseChanged?.Invoke();
        }


        public Customer GetCustomerById(int id)
        {
            return Customers.Find(x => x.Number == id);
        }

        public Product GetProductById(int id)
        {
            return Products.Find(x => x.Code == id);
        }

        public void AddNewCustomer(string _name, string _phone, string _email)
        {
            Customers.Add(new Customer(Customers.Count, _name, _phone, _email));
            RaiseWarehouseChanged();
        }

        public void AddNewOrder(Customer customer, string deliveryAddress, List<OrderLine> orderLines, bool paymentCompleted)
        {
            Orders.Add(new Order(Orders.Count, customer, deliveryAddress, orderLines, paymentCompleted));
            RaiseWarehouseChanged();
        }

        public void AddNewProduct(string name, double price, int stock)
        {
            Products.Add(new Product(Products.Count, name, price, stock));
            RaiseWarehouseChanged();
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

        public IEnumerable<Order> ReturnCustomersActiveOrders(int customerID)
        {
            IEnumerable<Order> activeUserOrders = Orders.Where
                (o => o.Dispatched == false
                || o.OrderDate.Subtract(DateTime.Now).TotalDays < 30);
            return activeUserOrders;
        }

        public IEnumerable<Order> ReturnCustomersArchivedOrders(int customerID)
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

        public void UpdateProductInformation(int id, string name, double price, int stock)
        {
            Product p = GetProductById(id);

            p.Name = name;
            p.Price = price;
            p.Stock = stock;

            RaiseWarehouseChanged();
        }

        public void UpdateCustomerInformation(int id, string name, string phone, string email)
        {
            Customer c = GetCustomerById(id);

            c.Name = name;
            c.Phone = phone;
            c.Email = email;

            RaiseWarehouseChanged();
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
