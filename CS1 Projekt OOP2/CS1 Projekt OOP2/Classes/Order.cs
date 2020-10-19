using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public class Order
    {
        public int Number { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public bool PaymentCompleted { get; set; }
        public bool PaymentRefunded { get; set; }
        public bool Distpatched { get; set; }
        public List<OrderLine> Items { get; set; }
    }
}
