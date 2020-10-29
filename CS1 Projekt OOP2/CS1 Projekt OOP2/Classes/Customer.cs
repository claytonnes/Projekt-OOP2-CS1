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

        private int _number;    
        private string _name;   
        private string _phone;  
        private string _email;  

        public Customer() 
        {
        }

        /// <summary>
        /// Initializes a new instance of the Customer class.
        /// </summary>
        /// <param name="nmb"></param>
        /// <param name="nm"></param>
        /// <param name="phn"></param>
        /// <param name="em"></param>
        public Customer(int number, string name, string phone, string email)
        {
            Number = number;
            Name = name;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Sets or gets the unique identifier of a Customer object
        /// </summary>
        public int Number 
        {
            get { return _number; }
            set { _number = (value < 0) ? throw new ArgumentOutOfRangeException() : value; } 
        }

        /// <summary>
        /// Sets or gets the name of a Customer object
        /// </summary>
        public string Name {
            get { return _name; }
            set { _name = (value == null || value == "") ? throw new NullValueException("Please enter a name.") : value; }
        }

        /// <summary>
        /// Sets or gets the telephone number of a Customer object
        /// </summary>
        public string Phone 
        {
            get { return _phone; }
            set { _phone = (value == null || value == "") ? throw new NullValueException("Please enter a name.") : value; }
        }

        /// <summary>
        /// Sets or gets the email address of a Customer object
        /// </summary>
        public string Email 
        {
            get { return _email; }
            set { _email = (value == null || value == "") ? throw new NullValueException("Please enter a name.") : value; }

        }
        public override string ToString()
        {
            return Name;
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
