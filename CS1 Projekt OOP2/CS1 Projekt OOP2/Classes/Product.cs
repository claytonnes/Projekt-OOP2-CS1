using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public class Product
    {

        private int _code; //får inte vara mindre än 0
        private string _name; // får inte vara null or empty
        private double _price; //får inte vara mindre än 0
        private int _stock; // får inte vara mindre än 0
        private DateTime _firstAvailable;
        private DateTime _nextStocking;

        public Product()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="stock"></param>
        public Product(int code, string name, double price, int stock)
        {
            Code = code;
            Name = name;
            Price = price;
            Stock = stock;
            NextStocking = DateTime.Now.AddDays(7);
            FirstAvailable = DateTime.Now;
        }

        /// <summary>
        /// Sets or gets the unique identifier of this Product.
        /// </summary>
        public int Code
        {
            get { return _code; }
            set { _code = (value < 0) ? throw new ArgumentException("Product code invalid") : value; }
        }

        /// <summary>
        /// Sets or gets the price of this Product.
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = (value < 0) ? throw new ArgumentException("Price cannot be negative") : value; }
        }
        /// <summary>
        /// Sets or gets the total amount of this Product in the warehouse stock.
        /// </summary>
        public int Stock
        {
            get { return _stock; }
            set { _stock = (value < 0) ? throw new ArgumentException("You can't add a negative stock value") : value; }
        }

        /// <summary>
        /// Sets or gets the name of this Product.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set {
                    if (value == "" || value == null) throw new ArgumentException("Please enter a name");
                        else _name = value;
                }
        }
        
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Sets or gets the date and time at which this Product will be re-stocked.
        /// </summary>
        public DateTime NextStocking {
            get { return _nextStocking; }
            set { _nextStocking = value;  } 
        }

        /// <summary>
        /// Sets or gets the date and time at which this Product is available for the first time.
        /// </summary>
        public DateTime FirstAvailable {
            get { return _firstAvailable; }
            set { _firstAvailable = value;  }
        }


    }
}
