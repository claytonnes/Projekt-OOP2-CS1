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
        public int _number;    // set value is unique and non-negative
        public string _name;   // non-empty value
        public string _phone;  // non-empty value
        public string _email;  // non-empty value

        public Customer()
        {
          
        }

        public int Number 
        {
            get { return _number; }
            set { _number = (value < 0) ? throw new ArgumentOutOfRangeException() : value; } 
        }

        public string Name 
        {
            get { return _name; }

            set {
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
