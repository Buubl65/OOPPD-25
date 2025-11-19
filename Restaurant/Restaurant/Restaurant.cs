using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Restaurant
    {
        public Menu Menu { get; } = new Menu();
        private List<Order> _orders = new List<Order>();

        public Order CreateOrder(int tableNumber)
        {
            var order = new Order(tableNumber);
            _orders.Add(order);
            return order;
        }

        public bool RemoveOrderById(int id)
        {
            var o = _orders.FirstOrDefault(x => x.Id == id);
            if (o == null) return false;
            return _orders.Remove(o);
        }

        public Order FindOrderById(int id) => _orders.FirstOrDefault(x => x.Id == id);

        public string GetActiveOrders()
        {
            if (_orders.Count == 0)
                return "Немає активних замовлень.";

            string result = "";

            foreach (var order in _orders)
            {
                result += $"ID: {order.Id} | Статус: {order.Status}\n";
            }

            return result;
        }
    }
}
