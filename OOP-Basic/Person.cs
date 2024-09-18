using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Basic
{
    internal class Person
    {
        public string Name { get; set; } = String.Empty;
    }

    internal class Employee : Person { 
        public int salary { get; set; }

    }

    internal class Admin : Employee
    {
        public string department { get; set; } = String.Empty;
    }
}
