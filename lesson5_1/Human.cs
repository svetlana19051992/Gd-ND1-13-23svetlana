using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_1
{
    public class Human : Transport
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

        public Human(string transportNameBase, double engineCapacityTransport, Transport manMoves)
            : base(transportNameBase, engineCapacityTransport)
        { 
            this._transport = manMoves;
        }
        public void ManMovesMethod(Transport transportUsed)
        {
            Console.WriteLine($"Man uses {transportUsed.TransportName}");
        }
        public void ShowChangeProperty()
        {
            Console.WriteLine($"Man uses {_transport.TransportName}");
        }

    }
}