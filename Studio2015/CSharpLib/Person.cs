using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public class Person : IPerson
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public void GetInfo(out int age, ref string info)
        {
            throw new NotImplementedException();
        }
        public void GetInfo(out string info)
        {
            throw new NotImplementedException();
        }
        public void GetInfo(string name, out int age, ref string info)
        {
            throw new NotImplementedException();
        }

        public bool GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
