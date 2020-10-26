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
        public OrderLine()
        {

        }
        public OrderLine(Product p, int c)
        {
            Product = p;
            Count = c;
        }

        public Product Product { 
            get { return _product; }
            set { _product = value; }
        }

        public int Count { 
            get { return _count; }
            set {
                _count = (value < 1) ? throw new ArgumentOutOfRangeException("You need to add atleast one of a product") : value;
            }
        }

        public override string ToString()
        {
            return $"{Count}x {Product}";
        }
    }
}
