using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CS1_Projekt_OOP2.Classes
{
    /// <summary>
    /// Delegate type used for handling change in the warehouse.
    /// </summary>
    public delegate void ChangeHandler();

    /// <summary>
    /// Warehouse class which handles all data actions and keeps a catalogue of customers, orders and products.
    /// Also deals with json-orders.
    /// </summary>
    class Warehouse : IWarehouse
    {
        private List<Product> _products;
        private List<Order> _orders;
        private List<Customer> _customers;

        /// <summary>
        /// Initializes a new instance of the Warehouse class.
        /// </summary>
        /// <remarks>At initialization this constructor:<br></br>
        /// (1) Initializes one list for our each of our three main datatypes: Products, Orders and Customers.<br></br>
        /// (2) Generates testdata 
        /// </remarks>
        public Warehouse()
        {
            Products = new List<Product>();
            Orders = new List<Order>();
            Customers = new List<Customer>();
            AddTestData();
        }

        /// <summary>
        /// Event of type ChangeHandler
        /// </summary>
        public event ChangeHandler WarehouseChanged;


        #region Properties

        /// <summary>
        /// Sets or gets the list of Products available to Order.
        /// </summary>
        public List<Product> Products 
        {
            get { return _products; }
            set { _products = value; } 
        }

        /// <summary>
        /// Sets or gets the list of all created and imported Orders.
        /// </summary>
        public List<Order> Orders 
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Sets or gets the list of all created customers.
        /// </summary>
        public List<Customer> Customers { 
            get{ return _customers; }
            set { _customers = value; }
        }

        #endregion


        #region Product-related methods
        /// <summary>
        /// Returns a product given a products product code
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Specific Product</returns>
        public Product GetProductById(int id)
        {
            return Products.Find(x => x.Code == id);
        }

        /// <summary>
        /// Adds a new product to Products
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        public void AddNewProduct(string name, double price, int stock)
        {
            Products.Add(new Product(Products.Count, name, price, stock));
            RaiseWarehouseChanged();
        }

        /// <summary>
        /// Updates an existing product's information
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        public void UpdateProductInformation(int id, string name, double price, int stock)
        {
            Product p = GetProductById(id);

            p.Name = name;
            p.Price = price;
            p.Stock = stock;

            RaiseWarehouseChanged();
        }



        /// <summary>
        /// Takes in a OrderLine-list
        /// Removes the stock for each product equal to the orderlines count.
        /// Does this for every orderline in the order.
        /// </summary>
        /// <param name="order"></param>
        public void DeductOrderLineCountFromProductStock(List<OrderLine> order)
        {
            foreach (OrderLine orderLine in order)
            {
                orderLine.Product.Stock -= orderLine.Count;
            }
        }

        /// <summary>
        /// Looks for all Products with Stock = 0
        /// 
        /// </summary>
        /// <returns>IEnumerable:Product with Products where Stock = 0</returns>
        public IEnumerable<Product> ReturnAllProductsWithZeroStock()
        {
            IEnumerable<Product> stockZeroProducts = Products.Where(p => p.Stock == 0);
            return stockZeroProducts;
        }

        #endregion


        #region Customer-related methods

        /// <summary>
        /// Returns a Customer from the list of Customers using customerId for the search
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Customer GetCustomerById(int id)
        {
            return Customers.Find(x => x.Number == id);
        }

        /// <summary>
        /// Adds a new customer to the list of customers and raises WarehouseChanged to update GUI.
        /// </summary>
        /// <param name="_name"></param>
        /// <param name="_phone"></param>
        /// <param name="_email"></param>
        public void AddNewCustomer(string _name, string _phone, string _email)
        {
            Customers.Add(new Customer(Customers.Count, _name, _phone, _email));
            RaiseWarehouseChanged();
        }

        /// <summary>
        /// Updates an existing customers information.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
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

        /// <summary>
        /// Returns an order from the list of orders using the order number for the search.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Specific order</returns>
        public Order GetOrderById(int id)
        {
            return Orders.Find(x => x.Number == id);
        }

        /// <summary>
        /// Adds a new order to the list of orders
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="deliveryAddress"></param>
        /// <param name="orderLines"></param>
        /// <param name="paymentCompleted"></param>
        public void AddNewOrder(Customer customer, string deliveryAddress, List<OrderLine> orderLines, bool paymentCompleted)
        {
            Orders.Add(new Order(Orders.Count, customer, deliveryAddress, orderLines, paymentCompleted));
            RaiseWarehouseChanged();
        }

        /// <summary>
        /// If any product in the order has a Product which is null, returns false, else return true
        /// </summary>
        /// <param name="o"></param>
        /// <returns>true if no null, false if null exists</returns>
        public bool TryOrderProducts(Order o)
        {
            return !o.Items.Any(a => a.Product == null);
        }

        /// <summary>
        /// Processes all orders in Orders. <br></br>
        /// If an order mentions a product which does not exist in the product list and payment is completed -> Refund<br></br>
        /// If an order has all its products, FirstAvailable is met and is not dispatched -> Dispatched
        /// </summary>
        public void ProcessOrders()
        {

            IEnumerable<Order> ordersToRefund =
               Orders.Where(a => a.Items.Any(b => b.Product == null || !Products.Contains(b.Product))
               && a.PaymentCompleted == true);

            foreach(Order o in ordersToRefund)
            {
                o.PaymentRefunded = true;
            }

            IEnumerable<Order> paymentCompleted = Orders.Where(
                a => a.PaymentRefunded == false
                && a.Items.All(b => b.Product.FirstAvailable <= DateTime.Now)
                && a.Dispatched == false
                && a.PaymentCompleted == true).OrderBy(a => a.OrderDate);

            foreach (Order order in paymentCompleted)
            {
                if (order.Items.All(o => o.Count <= o.Product.Stock))
                {
                    order.Dispatched = true;
                    DeductOrderLineCountFromProductStock(order.Items);
                }
            }
            RaiseWarehouseChanged();
        }

        /// <summary>
        /// Checks if products for and entire order is in stock.
        /// Returns true if all are in stock, returns false if not.
        /// </summary>
        /// <param name="o"></param>
        /// <returns>Returns true if all are in stock, returns false if not.</returns>
        private bool ProductsInStock(Order o)
        {
            return o.Items.All(a => a.Count <= a.Product.Stock);
        }



        /// <summary>
        /// Gets the earliest date and time an order can be dispatched.
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <returns>A DateTime reference representing when an Order can earliest be dispatched.</returns>
        /// <remarks>
        /// The returned DateTime is based on:<br></br>
        /// (1) If the stock will last for the given order if all pending orders with higher priority(i.e. OrderDate) are processed first. <br></br>
        /// (2) When the next stocking of all the products in the given order is.<br></br>
        /// (3) When all the products in the given order are available for the first time.
        /// </remarks>
        public DateTime GetEarliestDispatchTime(int orderNumber)

        /// <returns>Earliest dispatch time for an order.</returns>
        

        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            


            Order o = GetOrderById(orderNumber);
            DateTime latestFirstAvailable =
                o.Items.Select(a => a.Product).Max(a => a.FirstAvailable);

            DateTime latestRestocking =
                o.Items.Select(a => a.Product).Max(a => a.NextStocking);

            if (!StockIsEnoughForAllProductsInOlderOrdersAndThis(o))
            {
                if (latestRestocking > latestFirstAvailable)
                    return latestRestocking;
                else return latestFirstAvailable;
            }
            else if (latestFirstAvailable > DateTime.Now)
                return latestFirstAvailable;
            else return o.OrderDate;
        }

        //Helper for GetEarliestDispatchTime()
        private bool StockIsEnoughForAllProductsInOlderOrdersAndThis(Order o)
        {
            foreach(OrderLine ol in o.Items)
            {
                if(!StockIsEnoughForOneProductInOlderOrdersAndThis(ol.Product, o))
                {
                    return false;
                }
            }
            return true;
        }

        //Helper for GetEarliestDispatchTime()
        private bool StockIsEnoughForOneProductInOlderOrdersAndThis(Product p, Order o)
        {
            List<Order> allRelevantOrders = Orders.Where(order => !order.Dispatched &&
                                                                  !order.PaymentRefunded
                                                                   ).ToList();

            int sumOfProductAmountToBeDispatched = 0;

            foreach(Order currentOrder in allRelevantOrders)
            {
                
                sumOfProductAmountToBeDispatched += GetAmountOfProductInOrder(p, o);
                if (currentOrder.Number == o.Number) break;
            }

            return p.Stock >= sumOfProductAmountToBeDispatched;
        }

        //Helper for GetEarlistDispatchTime()
        private int GetAmountOfProductInOrder(Product p, Order o)
        {
            int sum = 0;
            foreach(OrderLine ol in o.Items)
            {
                sum += ol.Product.Code == p.Code ? ol.Count : 0; 
            }
            return sum;
        }


        /// <summary>
        /// Returns an IEnumerable:Order of a specific customer's active orders.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>IEnumerable:Order of a specific customer's active orders</returns>
        public IEnumerable<Order> ReturnCustomersActiveOrders(int customerID)
        {
            IEnumerable<Order> activeUserOrders = Orders.Where
                (o => o.Customer.Number == customerID &&
                (o.Dispatched == false || DateTime.Now.Subtract(o.OrderDate).TotalDays < 30));

            return activeUserOrders;
        }

        /// <summary>
        /// Returns an IEnumerable:Order of a specific customer's archived orders. <br></br>
        /// Archived orders are at least 30 days old and dispatched.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns>IEnumerable:Order of a specific customer's archived orders</returns>
        public IEnumerable<Order> ReturnCustomersArchivedOrders(int customerID)
        {
            IEnumerable<Order> archivedUserOrders = Orders.Where
                (o => o.Customer.Number == customerID &&
                (o.Dispatched == true && DateTime.Now.Subtract(o.OrderDate).TotalDays >= 30));
            return archivedUserOrders;
        }

        /// <summary>
        /// Returns all orders from Orders with Dispatched = true
        /// </summary>
        /// <returns>IEnumerable:Order of orders with Dispatched = true</returns>
        public IEnumerable<Order> ReturnDispatchedOrders()
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == true).OrderBy(o => o.OrderDate);
            return dispatchedOrders;
        }

        /// <summary>
        /// Returns all orders from Orders with Dispatched = false
        /// </summary>
        /// <returns>IEnumerable:Order of orders with Dispatched = false</returns>
        public IEnumerable<Order> ReturnPendingOrders()
        {
            IEnumerable<Order> dispatchedOrders = Orders.Where(o => o.Dispatched == false).OrderBy(o => o.OrderDate);
            return dispatchedOrders;
        }

        #endregion


        #region Utilities

        /// <summary>
        /// Raises event WarehouseChanged when called.
        /// </summary>
        public void RaiseWarehouseChanged()
        {
            WarehouseChanged?.Invoke();
        }

        /// <summary>
        /// Adds testdata for the Lists: Products, Customers, Orders.
        /// </summary>
        private void AddTestData()
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

            Customer test = new Customer() { Number = 99, Name = "testperson", Email = "test@test", Phone = "000000" };

            OrderLine ol1 = new OrderLine() { Product = GetProductById(6), Count = 3 };
            OrderLine ol2 = new OrderLine() { Product = GetProductById(6), Count = 1 };
            OrderLine ol3 = new OrderLine() { Product = GetProductById(0), Count = 1 };
            OrderLine ol4 = new OrderLine() { Product = GetProductById(0), Count = 1 };
            OrderLine ol5 = new OrderLine() { Product = GetProductById(6), Count = 1 };



            //Visar att earliestDispatch fungerar och att Stock krävs
            Order testOrder1 = new Order(0, Customers[0], "Nymanvägen 11", new List<OrderLine> { ol1 }, true);
            Order testOrder2 = new Order(1, Customers[0], "Nymanvägen 11", new List<OrderLine> { ol2 }, true);

            //Visar att paymentComplete måste vara true
            Order testOrder3 = new Order(2, Customers[1], "Engvallskurvan 22", new List<OrderLine> { ol3 }, true);
            Order testOrder4 = new Order(3, Customers[1], "Envallskruvan 22", new List<OrderLine> { ol4 }, false);

            //Visar att om refunded => blir inte dispatched
            Order testOrder5 = new Order(4, Customers[2], "Bleckertsjö 7", new List<OrderLine> { ol3 }, true);
            testOrder5.PaymentRefunded = true;

            //Visar att om dispatched => visas i nedre listan
            Order testOrder6 = new Order(5, Customers[3], "Birganderträsk 1", new List<OrderLine> { ol3 }, true);
            testOrder6.Dispatched = true;

            //Visar att om produkten inte finns i Products så refundas ordern
            Product foreignProduct = new Product(999, "Specialized tool", 0, 0);
            OrderLine badOrderLine = new OrderLine(foreignProduct, 1);

            Order testOrder7 = new Order(6, Customers[4], "Bergsjöland 22", new List<OrderLine> { badOrderLine }, true);

            Orders.Add(testOrder1);
            Orders.Add(testOrder2);
            Orders.Add(testOrder3);
            Orders.Add(testOrder4);
            Orders.Add(testOrder5);
            Orders.Add(testOrder6);
            Orders.Add(testOrder7);






            //List<OrderLine> items = new List<OrderLine>();
            //OrderLine item = new OrderLine(Products[0], 11);
            //items.Add(item);
            //AddNewOrder(Customers[0], "Leveransvägen 1", items, true);
            //Products[1].FirstAvailable = DateTime.Now.AddDays(1);

            ////Testdata för att visa att pending/dispatched-sorteringen fungerar.
            //AddNewOrder(Customers[0], "Vägvägen11", items, true);
            //Orders[1].Dispatched = true;

            //items.Clear();
            //items.Add(new OrderLine(Products[0], 3));
            //AddNewOrder(Customers[0], "Archivedgatan 11", items, true);
            //Orders[2].Dispatched = true;
            //Orders[2].OrderDate = new DateTime(2008, 5, 1, 8, 30, 52);

        }

        

        //Checks if the json-orders order number already exists and throws exception if it does.
        private void TryOrderNumber(int orderNumber)
        {
            if (Orders.Any(o => o.Number == orderNumber))
                throw new Exception("Error adding order from JSON-file: order number already exists.");
        }

        /// <summary>
        /// Initializes a FileSystemWatcher and subscribes Fsw_Created to it.
        /// Keeps track if new orders arrive in neworders.
        /// </summary>
        /// <param name="form"></param>
        public void WatchNewOrders(Form form)
        {
            if (!System.IO.Directory.Exists("./neworders"))
            {
                System.IO.Directory.CreateDirectory("./neworders");
            }

            FileSystemWatcher fsw = new FileSystemWatcher("./neworders", "*.json");
            fsw.SynchronizingObject = form;
            fsw.Created += Fsw_Created;
            fsw.EnableRaisingEvents = true;
        }

        //Deserializes the json-order and tries adjusting and adding it. Deletes the json-file after.
        private void Fsw_Created(object sender, FileSystemEventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(500);
                string json = File.ReadAllText(e.FullPath);
                Order o = JsonSerializer.Deserialize<Order>(json);
                Order order = AdjustOrder(o);
                Orders.Add(order);
                RaiseWarehouseChanged();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            File.Delete(e.FullPath);
        }


        /// <summary>
        /// Adjusts orders received by json-files.
        /// Checks if there is a collison if OrderNumbers
        /// Assigns the order with an actual reference to the customer
        /// Assigs the order with references to actual products.
        /// </summary>
        /// <param name="o"></param>
        /// <returns>Adjusted Order with correct references.</returns>
        public Order AdjustOrder(Order o)
        {
            TryOrderNumber(o.Number);
            o.Customer = GetCustomerById(o.Customer.Number);
            foreach (OrderLine ol in o.Items)
            {
                ol.Product = GetProductById(ol.Product.Code);
            }
            return o;
        }

        #endregion
    }
}

