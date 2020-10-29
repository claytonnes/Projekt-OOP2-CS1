using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public class Order
    {
        private int _number;
        private Customer _customer;
        private DateTime _orderDate;
        private string _deliveryAddress;
        private bool _paymentCompleted;
        private bool _paymentRefunded;
        private bool _dispatched;
        private List<OrderLine> _items;

        public Order()
        {
            
        }


        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        /// <param name="number">Unique identifier</param>
        /// <param name="customer"></param>
        /// <param name="deliveryAddress"></param>
        /// <param name="items"></param>
        /// <param name="paymentCompleted"></param>
        public Order(int number, Customer customer, string deliveryAddress, List<OrderLine> items, bool paymentCompleted)
        {
            Number = number;
            Customer = customer;
            OrderDate = DateTime.Now;
            DeliveryAddress = deliveryAddress;
            Items = items;
            PaymentCompleted = paymentCompleted;
            PaymentRefunded = false;
            Dispatched = false;
        }

        /// <summary>
        /// Sets or gets the unique identifier of an Order object.
        /// </summary>
        public int Number { 
            get { return _number; }
            set { _number = (value < 0) ? throw new ArgumentException("Faulty order number") : value; }
        }

        /// <summary>
        /// Sets or gets the Customer object associated with this Order.
        /// </summary>
        public Customer Customer
        {
            get { return _customer; }
            set { _customer = (value == null) ? throw new ArgumentException("Please pick a customer.") : value; }
        }

        /// <summary>
        /// Sets or gets the date and time this Order was placed.
        /// </summary>
        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        /// <summary>
        /// Sets or gets the intended delivery address for this Order.
        /// </summary>
        public string DeliveryAddress
        {
            get { return _deliveryAddress; }
            set { _deliveryAddress = (value == "" || value == null) ? throw new ArgumentException("Please enter the delivery address.") : value; }
        }

        /// <summary>
        /// Sets or gets whether this Order has been paid for.
        /// </summary>
        public bool PaymentCompleted
        {
            get { return _paymentCompleted; }
            set { _paymentCompleted = value; }
        }

        /// <summary>
        /// Sets or gets whether this Order has been refunded.
        /// </summary>
        public bool PaymentRefunded { 
            get { return _paymentRefunded; }
            set { _paymentRefunded = value; }
        }

        /// <summary>
        /// Sets or gets whether this Order has been dispatched.
        /// </summary>
        public bool Dispatched { 
            get { return _dispatched; }
            set { _dispatched = value; }
        }

        /// <summary>
        /// Sets or gets the list of all OrderLine objects associated with this Order.
        /// </summary>
        public List<OrderLine> Items { 
            get { return _items; }
            set {_items = value;} 
        }
    }
}
