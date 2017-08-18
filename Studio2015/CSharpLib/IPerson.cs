using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }

        void GetInfo(out string info);
        void GetInfo(out int age, ref string info);
        void GetInfo(string name, out int age, ref string info);
        bool GetInfo();
    }
}
