using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7_1
{
    public class DoesNotEndWithADotException : ApplicationException
    {        
        public DoesNotEndWithADotException(string message) : base(message)
        { }                  
    }
}