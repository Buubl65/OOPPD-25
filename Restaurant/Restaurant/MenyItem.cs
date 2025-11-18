using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class MenyItem : MenuItemPrintable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Category Category { get; set; }

        public MenyItem(int id, string name, decimal price, Category category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }

        public abstract string GetDisplayText();
    }
}
