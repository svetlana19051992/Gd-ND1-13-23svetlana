using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lesson7_1
{
    public class AClass
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public AClass(string name)
        {
            Name = name;
        }

        public void ShowNonEmptyName()
        {
            if (Name == "")
                throw (new EmptyNameException("Empty name Exception"));
            else 
            {
                Console.WriteLine(Name);
            }
        }
        
        public void ShowNameEndingWithDot()
        {
            if (_name[_name.Length - 1] != '.')
                throw (new DoesNotEndWithADotException("Does not end with a dot Exception"));
            else
            {
                Console.WriteLine(Name);
            }
        }        
    }
}