using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

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
            AddTestData();
        }

        public event ChangeHandler WarehouseChanged;

        public void RaiseWarehouseChanged()
        {
            WarehouseChanged?.Invoke();
        }



        #region Product-related methods

        public Product GetProductById(int id)
        {
            return Products.Find(x => x.Code == id);
        }

        public void AddNewProduct(string name, double price, int stock)
        {
            Products.Add(new Product(Products.Count, name, price, stock));
            RaiseWarehouseChanged();
        }

        public void UpdateProductInformation(int id, string name, double price, int stock)
        {
            Product p = GetProductById(id);

            p.Name = name;
            p.Price = price;
            p.Stock = stock;

            RaiseWarehouseChanged();
        }

        public void DeductOrderLineCountFromProductStock(List<OrderLine> order)
        {
            foreach (OrderLine orderLine in order)
            {
                orderLine.Product.Stock -= orderLine.Count;
            }
        }

        public IEnumerable<Product> ReturnAllProductsWithZeroStock()
        {
            IEnumerable<Product> stockZeroProducts = Products.Where(p => p.Stock == 0);
            return stockZeroProducts;
        }

        #endregion



        #region Customer-related methods

        public Customer GetCustomerById(int id)
        {
            return Customers.Find(x => x.Number == id);
        }

        public void AddNewCustomer(string _name, string _phone, string _email)
        {
            Customers.Add(new Customer(Customers.Count, _name, _phone, _email));
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
        #endregion



        #region Order-related methods

        public Order GetOrderById(int id)
        {
            return Orders.Find(x => x.Number == id);
        }

        public void AddNewOrder(Customer customer, string deliveryAddress, List<OrderLine> orderLines, bool paymentCompleted)
        {
            Orders.Add(new Order(Orders.Count, customer, deliveryAddress, orderLines, paymentCompleted));
            RaiseWarehouseChanged();
        }

        public void ProcessOrders()
        {
            IEnumerable<Order> paymentCompleted = Orders.Where(
                a => a.PaymentCompleted == true
                && a.Items.All(b => b.Product.FirstAvailable <= DateTime.Now)
                && a.Dispatched == false).OrderBy(a => a.OrderDate);

            foreach (Order order in paymentCompleted)
            {
                if (order.Items.All(o => o.Count < o.Product.Stock))
                {
                    order.Dispatched = true;
                    DeductOrderLineCountFromProductStock(order.Items);
                }
            }

            RaiseWarehouseChanged();
        }

        public IEnumerable<Order> ReturnCustomersActiveOrders(int customerID)
        {
            IEnumerable<Order> activeUserOrders = Orders.Where
                (o => o.Customer.Number == customerID &&
                (o.Dispatched == false || o.OrderDate.Subtract(DateTime.Now).TotalDays < 30));

            return activeUserOrders;
        }

        public IEnumerable<Order> ReturnCustomersArchivedOrders(int customerID)
        {
            IEnumerable<Order> archivedUserOrders = Orders.Where
                (o => o.Customer.Number == customerID &&
                (o.Dispatched == true && o.OrderDate.Subtract(DateTime.Now).TotalDays >= 30));
            return archivedUserOrders;
        }
        public IEnumerable<Order> ReturnDispatchedOrders()
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true).OrderBy(o => o.OrderDate);
            return dispatchedOrders;
        }

        public IEnumerable<Order> ReturnPendingOrders()
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == false).OrderBy(o => o.OrderDate);
            return dispatchedOrders;
        }

        #endregion

        public void AddTestData()
        {
            // Test-data
            AddNewProduct("Shampoo", 24.99, 21);
            AddNewProduct("Conditioner", 24.99, 22);
            AddNewProduct("Toilet paper", 34.99, 41);
            AddNewProduct("Canned tuna", 11.49, 34);
            AddNewProduct("Beer can", 12.99, 24);
            AddNewProduct("Chocolate bar", 9.99, 15);
            AddNewProduct("Bag of avocados", 239.99, 3);
            AddNewProduct("Milk carton", 10.99, 4);




            AddNewCustomer("Moa", "018-34567", "mosis@test.com");
            AddNewCustomer("Jens", "018-34135", "jensis@test.com");
            AddNewCustomer("Victor", "018-15123", "virre@test.com");
            AddNewCustomer("Nazgul", "018-18736", "naz@test.com");
            AddNewCustomer("Christer", "018-18254", "christer@stuxnet.com");
            AddNewCustomer("Stefan", "018-34651", "steffecool@regeringen.se");
            AddNewCustomer("Bruce", "018-75345", "batman@wayneenterprises.com");
            AddNewCustomer("Joakim", "018-24572", "getdatmoney@jva.com");





            List<OrderLine> items = new List<OrderLine>();
            OrderLine item = new OrderLine(Products[0], 11);
            Products[0].FirstAvailable = new DateTime(2020, 6, 3, 22, 15,0);
            Products[3].FirstAvailable = new DateTime(2020, 6, 3, 22, 15, 0);
            items.Add(item);
            AddNewOrder(Customers[0], "Leveransvägen 1", items, true);

            //Testdata för att visa att pending/dispatched-sorteringen fungerar.
            AddNewOrder(Customers[0], "Vägvägen11", items, true);
            Orders[1].Dispatched = true;

            /* Test-data
            AddNewProduct("Tooth brash", 12.50, 50);

            AddNewCustomer("Jens", "012-09876", "test1@test1.com");
            List<OrderLine> sanitary = new List<OrderLine>();
            _ = new OrderLine(Products[1], 12);
            items.Add(item);
            AddNewOrder(Customers[1], "Statsvägen 2", items, false);

            //Testdata för att visa att pending/dispatched-sorteringen fungerar.
            AddNewOrder(Customers[1], "Strandvägen 23", items, true);
            Orders[1].Dispatched = false; */
        }

        public Order AdjustOrder(Order o)
        {
            o.Number = Orders.Max(a => a.Number) + 1;
            o.Customer = GetCustomerById(o.Customer.Number);
            foreach (OrderLine ol in o.Items)
            {
                ol.Product = GetProductById(ol.Product.Code);
            }
            return o;
        }
    }
}
