using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_2
{
    public class Car : Transport
    {
        public Car(string transportNameBase, double engineCapacityTransport)
            : base(transportNameBase, engineCapacityTransport) { }

        public new void Move()
        {
            Console.WriteLine("The car is driving.");
        }
    }
}