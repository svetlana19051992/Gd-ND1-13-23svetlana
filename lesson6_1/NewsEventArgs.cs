using lesson6_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6_5
{
    public class NewsEventArgs : EventArgs
    {
        public News NewsType { get; set; }
        public string NewsText { get; set; }
    }
}