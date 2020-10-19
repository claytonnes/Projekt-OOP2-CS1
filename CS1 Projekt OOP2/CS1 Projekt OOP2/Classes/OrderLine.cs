using CS1_Projekt_OOP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public class OrderLine
    {
        private Product _product;
        private int _count;
        public OrderLine(Product p, int c)
        {
            _product = p;
            _count = c;
        }

        public Product Product { 
            get { return _product; }
            set { _product = value; }
        }

        public int Count { 
            get { return _count; }
            set { _count = value; } 
        }
    }
}
