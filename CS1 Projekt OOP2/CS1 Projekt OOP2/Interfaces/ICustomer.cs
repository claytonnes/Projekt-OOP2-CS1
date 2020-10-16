using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1_Projekt_OOP2
{
    public interface ICustomer
    {
        int Number { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}
