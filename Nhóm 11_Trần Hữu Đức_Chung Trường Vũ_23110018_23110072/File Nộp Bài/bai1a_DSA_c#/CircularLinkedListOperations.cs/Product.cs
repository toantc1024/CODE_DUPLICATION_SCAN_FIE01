using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedListOperations.cs
{
    public class Product
    {
        // private fields
        private string name;
        private float price;

        // public properties với cả getter và setter
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        // Constructor
        public Product(string name, float price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
