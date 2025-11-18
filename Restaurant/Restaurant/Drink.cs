using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Drink : MenyItem
    {
        public int Volume { get; set; }
        public bool IsAlcohole { get; set; }

        public Drink (int id, string name, decimal price,  int volume, bool isAlcohole, Category category) : base ( id, name, price, category)
        {
            Volume = volume;
            IsAlcohole = isAlcohole;
            Category = Category.Drink;
        }

        public override string GetDisplayText()
        {
            string alc = IsAlcohole ? "алкогольний" : "без алкогольний";
            return $"{Id}. {Name} ({Volume}) мл, {alc} - {Price} грн.";
        }
    }
}
