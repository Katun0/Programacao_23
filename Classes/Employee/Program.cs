using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prog3_23.classes
{
    public class Employee : Person
    {
        public string? JobTitle { get; set; }
        public decimal Salary { get; set; }
    }
}