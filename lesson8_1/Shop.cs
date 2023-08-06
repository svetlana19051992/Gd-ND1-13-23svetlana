using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lesson8_1
{
    public class Shop
    {
        public Salesman Salesman { get; set; }
        public Product Product { get; set; }
    }

    public class Salesman
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }
    }

    public class Product
    {
        private int _quantity { get; set; }
        public string NameProduct { get; set; }
        public int Quantity 
        {
            get { return _quantity; }
            set
            {
                _quantity = value < 0 ? 0 : value;                   
            }
        }
    }
}
