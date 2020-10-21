﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public class Customer
    {
        //Ask Christer
        internal static int Count; // Increases every time a new customer is created

        private int _number;    // set value is unique and non-negative
        private string _name;   // non-empty value
        private string _phone;  // non-empty value
        private string _email;  // non-empty value

        public Customer() //what is this constructor for?
        {
        }

        public Customer(int nmb, string nm, string phn, string em)
        {
            Number = nmb; Name = nm;
            Phone = phn; Email = em;
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
                if (value == null || value == "")
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
                if (value == null || value == "")
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
                if (value == null || value == "")
                    throw new NullValueException(" Email cannot be null ");
                else
                    _email = value;
            }
        }
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
