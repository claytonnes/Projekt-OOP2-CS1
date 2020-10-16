using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public interface IProduct
    {
        int Code { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        int Stock { get; set; }
        DateTime FirstAvailable { get; set; }
        DateTime NextStocking { get; set; }
    }
}
