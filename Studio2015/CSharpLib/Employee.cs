using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public class Employee : Person
    {
        public Employee(string name, int age) : base(name, age)
        {
        }

        public bool IsManager { get; set; }
    }
}
