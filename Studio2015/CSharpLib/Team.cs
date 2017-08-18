using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLib
{
    public class Team
    {
        private List<Employee> _employees;

        public List<Employee> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
            }
        }

        public void GetEmployees()
        {
            throw (new NotImplementedException());

            //if (_employees == null)
            //{
            //    _employees = new List<Employee>();
            //    _employees.Add(new Employee("David", 20));
            //    _employees.Add(new Employee("Catherine", 17));
            //}
        } 
    }
}
