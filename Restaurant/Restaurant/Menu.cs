using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Menu
    {
        private List<MenyItem> _items = new List<MenyItem>();
        private int _index = 1;

        public void AddDish(Dish dish)
        {
            dish.Id = _index++;
            _items.Add(dish);
        }

        public void AddDrink(Drink drink)
        {
            drink.Id = _index++;
            _items.Add(drink);
        }

        public bool RemoveById(int id)
        {
            var item = _items.FirstOrDefault(i => i.Id == id);
            if(item == null) return false;
            return _items.Remove(item);
        }

        public MenyItem FindById(int id)
        {
            return _items.FirstOrDefault(i => i.Id == id);
        }

        public List<MenyItem> FindByCategory(Category category)
        {
            return _items.Where(i => i.Category == category).ToList();
        }

        public string GetAll()
        {
            if (_items.Count == 0)
                return "Меню порожнє.";

            string output = "--- МЕНЮ РЕСТОРАНУ ---\n";

            foreach (var item in _items)
            {
                output += item.GetDisplayText() + "\n";
            }

            output += "-----------------------";

            return output;
        }
        
    }
}
