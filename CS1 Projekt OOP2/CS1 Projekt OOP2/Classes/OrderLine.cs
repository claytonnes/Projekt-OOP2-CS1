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

        /// <summary>
        /// Initializes an instance of the OrderLine class: A pair of one Product object and how many of it, represented as an integer.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="count"></param>
        public OrderLine(Product product, int count)
        {
            Product = product;
            Count = count;
        }

        /// <summary>
        /// Sets or gets the Product object of this OrderLine.
        /// </summary>
        public Product Product { 
            get { return _product; }
            set { _product = value; }
        }

        /// <summary>
        /// Sets or gets the amount of this OrderLines selected Product.
        /// </summary>
        public int Count { 
            get { return _count; }
            set { _count = (value < 1) ? throw new ArgumentOutOfRangeException("You need to add atleast one of a product") : value; }
        }

        public override string ToString()
        {
            return $"{Count}x {Product}";
        }
    }
}
