using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_Linked_List
{
    public class Clothes
    {
        private string id;
        private string name;
        private string type;
        private string size;
        private int price;

        public string ID
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Type
        {
            get => type;
            set => type = value;
        }
        public string Size
        {
            get => size;
            set => size = value;
        }
        public int Price
        {
            get => price;
            set => price = value;
        }

        public Clothes()
        {

        }
        public Clothes(string id, string type, string name, string size, int price)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.size = size;
            this.price = price;
        }

        public Clothes(string criteria, string value)
        {
            this.id = "";
            this.type = "";
            this.price = 0;
            this.size = "";
            this.name = "";
            switch (criteria)
            {
                case "id": this.id = value; break;
                case "name": this.name = value; break;
                case "type": this.type = value; break;
                case "size": this.size = value; break;
                case "price": this.price = int.Parse(value); break;
            }
        }

        public bool CheckValue(string criteria, string value)
        {
            switch (criteria)
            {
                case "id": return this.id == value; break;
                case "name": return this.name == value; break;
                case "type": return this.type == value; break;
                case "size": return this.size == value; break;
                case "price": return this.price == int.Parse(value); break;
            }
            return false;
        }
        public override string ToString()
        {
            return $"ID: {id}, Type: {type}, Name: {name}, Size: {size}, Price: {price}";
        }
    }
}
