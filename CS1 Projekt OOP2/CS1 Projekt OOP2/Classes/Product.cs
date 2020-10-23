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

        public Product()
        {

        }

        public Product(int code, string name, double price, int stock)
        {
            Code = code;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public int Code
        {
            get { return _code; }
            set { _code = (value < 0) ? throw new ArgumentException("Product code invalid") : value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = (value < 0) ? throw new ArgumentException("Price cannot be negative") : value; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = (value < 0) ? throw new ArgumentException("You can't add a negative stock value") : value; }
        }


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
        //Ask Christer
        public DateTime FirstAvailable { get; set; }
        public DateTime NextStocking { get; set; }

    }
}
