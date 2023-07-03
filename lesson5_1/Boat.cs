using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_1
{
    public class Boat : Transport
    {
        public Boat(string transportNameBase, double engineCapacityTransport)
            : base(transportNameBase, engineCapacityTransport) { }  
        
        public new void Move()
        {
            Console.WriteLine("The boat is sailing");
        }
    }
}