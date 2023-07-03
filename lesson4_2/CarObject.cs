using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4_2
{
    public class CarObject : NameObject
    {
        public override required string Name { get; set; }
        public double EngineCapacity { get; set; }
    }
}