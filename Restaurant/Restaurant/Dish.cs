using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Dish : MenyItem
    {

        public Dish(int id, string name, decimal price, Category category) : base(id, name, price, category)
        {
            Category = category;
        }
        public override string GetDisplayText()
        {
            return $"{Id}. {Name} ({Category}) - {Price} грн";
        }
    }
}
