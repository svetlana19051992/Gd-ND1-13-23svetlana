using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_1
{
    public class EmptyNameException : ApplicationException
    {
        public EmptyNameException(string message) : base(message)
        { }        
    }
}