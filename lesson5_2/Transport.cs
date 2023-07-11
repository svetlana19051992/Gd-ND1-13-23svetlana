using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_2
{
    public class Transport
    {
        public string TransportName { get; set; }
        public double EngineCapacity { get; set; }
        public Transport(string transportNameBase, double engineCapacityTransport)
        {
            TransportName = transportNameBase;
            EngineCapacity = engineCapacityTransport; 
        }
        public void Move()
        {
            Console.WriteLine("Way to travel.");
        }
    }
}