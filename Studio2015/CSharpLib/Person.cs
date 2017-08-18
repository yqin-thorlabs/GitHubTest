using System;

namespace CSharpLib
{
    public class Person : IPerson
    {
        private int _age;
        private string _name;

        // virtual member / function may be overridden many times, 
        // only the most derived type will be executed. So virtual member / function
        // should not be called in constructor
        public Person()
        {

        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public virtual int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void GetInfo(out int age, ref string info)
        {
            throw new NotImplementedException();
        }

        public void GetInfo(out string info)
        {
            throw new NotImplementedException();
        }

        public virtual void GetInfo(string name, out int age, ref string info)
        {
            throw new NotImplementedException();
        }

        public bool GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}