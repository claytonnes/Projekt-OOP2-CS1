using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public class Order
    {
        private int _number; //Unikt och icke-negativt
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

        //Ej unikt. Unikt genereras i Warehouse?
        public int Number { 
            get { return _number; }
            set { _number = (value < 0) ? throw new ArgumentOutOfRangeException("Faulty order number") : value; }
        }

        public Customer Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }

        public string DeliveryAddress
        {
            get { return _deliveryAddress; }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("Please enter the delivery address.");
                else _deliveryAddress = value;
            }
        }

        public bool PaymentCompleted
        {
            get { return _paymentCompleted; }
            set { _paymentCompleted = value; }
        }

        public bool PaymentRefunded { 
            get { return _paymentRefunded; }
            set { _paymentRefunded = value; }
        }

        public bool Dispatched { 
            get { return _dispatched; }
            set { _dispatched = value; }
        }

        public List<OrderLine> Items { 
            get { return _items; }
            set { _items = value; } }
    }
}
