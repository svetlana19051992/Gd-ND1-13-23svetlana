using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_2
{
    public class Human
    {
        private Transport _transport;

        public Transport HumanTransport
        {
            get
            {
                return _transport;
            }
            set
            {
                _transport = value;
            }
        }

        public void ManMovesMethod()
        {
            Console.WriteLine($"Man uses {HumanTransport.TransportName}");
        }
        public void ChangeTransport(Transport ChangeTransportName)
        {
            HumanTransport = ChangeTransportName;
        }

    }
}