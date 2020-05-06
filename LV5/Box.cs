using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lv_4
{
    class Box : IShipable

    {
        private List<IShipable> items;
        private string name;
        private double weight = 0;
        public Box(string name)
        {
            this.items = new List<IShipable>();
            this.name = name;
        }
        public void Add(IShipable item)
        {
            this.items.Add(item);
            this.weight += item.Weight; 
        }
        public void Remove(IShipable item)
        {
            this.items.Remove(item);
            this.weight -= item.Weight;
        }
        public double Price
        {
            get
            {
                double totalPrice = 0;
                foreach (IShipable item in items)
                {
                    totalPrice += item.Price;
                }
                return totalPrice;
            }
        }
        public double Weight
        {
            get
            {
                return this.weight;
            }
        }
        public string Description(int depth = 0)
        {
            StringBuilder builder =
           new StringBuilder(new string(' ', depth) + this.name + "\n");
            foreach (IShipable item in items)
            {
                builder.Append(item.Description(depth + 2)).Append("\n");
            }
            return builder.ToString();
        }
    }
}
