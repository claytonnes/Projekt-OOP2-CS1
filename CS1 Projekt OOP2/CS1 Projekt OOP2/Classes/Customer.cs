using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public class Customer
    {
        internal static int Count; // Increases every time a new customer is created

        private int _number;    // set value is unique and non-negative
        private string _name;   // non-empty value
        private string _phone;  // non-empty value
        private string _email;  // non-empty value
        private int v1;
        private bool v2;

        public Customer(int v1, bool v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Customer(int _number, string _name, string _phone, string _email)
        {
            Number = _number; Name = _name;
            Phone = _phone; Email = _email;
        }

        public int Number 
        {
            get { return _number; }
            set { _number = (value < 0) ? throw new ArgumentOutOfRangeException() : value; } 
        }

        public string Name {
            get { return _name; }
            set
            {
                if (_name == null || _name == "")
                    throw new NullValueException(" Name cannot be null ");
                else
                    _name = value;
            }
        }
        public string Phone 
        {
            get { return _phone; }
            set
            {
                if (_phone == null || _phone == "")
                    throw new NullValueException(" Phone cannot be null ");
                else
                    _phone = value;
            }
        } 
        public string Email 
        {
            get { return _email; }
            set
            {
                if (_email == null || _email == "")
                    throw new NullValueException(" Email cannot be null ");
                else
                    _email = value;
            }
        }
        /*public void AddNewCustomer();
        public void UpdateCustomerName(int id, string name);
        public void UpdateCustomerPhone(int id, string phone);
        public void UpdateCustomerEmail(int id, string email);*/
        
        public override string ToString()
        {
            return $"ID:{Number} Customer name:{Name} Customer phone:{Phone} Customer email:{Email}";
        }

        internal static int Max(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable]
    internal class NullValueException : Exception
    {
        public NullValueException()
        {
        }
        public NullValueException(string message) : base(message)
        {
        }
        public NullValueException(string message, Exception innerException) : base(message, innerException)
        {
        }
        protected NullValueException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
