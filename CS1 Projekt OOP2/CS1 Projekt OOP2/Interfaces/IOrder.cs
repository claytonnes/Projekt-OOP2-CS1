using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public interface IOrder
    {
        int Number { get; set; }
        Customer Customer { get; set; }
        DateTime OrderDate { get; set; }
        string DeliveryAddress { get; set; }
        bool PaymentCompleted { get; set;}
        bool PaymentRefunded { get; set; }
        bool Distpatched { get; set; }
        List<OrderLine> Items { get; set; }
    }
}
