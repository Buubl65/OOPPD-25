using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Order
    {
        private static int _orderId = 100;
        private List<MenyItem> _orderItems;

        public int Id { get; }
        public OrderStatus Status { get; set; }
        public int TableNumber { get; set; }
        public DateTime CreatedAt { get; }

        public Order(int tableNumber)
        {
            Id = ++_orderId;
            Status = OrderStatus.Pending;
            TableNumber = tableNumber;
            CreatedAt = DateTime.Now;
            _orderItems = new List<MenyItem>();
        }

        public void AddItem(MenyItem item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _orderItems.Add(item);
        }

        public bool RemoveItemByMenuId(int menuItemId)
        {
            var found = _orderItems.FirstOrDefault(i => i.Id == menuItemId);
            if (found == null) return false;
            _orderItems.Remove(found);
            return true;
        }

        public decimal CalculateTotal()
        {
            return _orderItems.Sum(i => i.Price);
        }

        public void SetStatus(OrderStatus status)
        {
            Status = status;
        }

        public string OrderInfo()
        {
            return $"ID: {Id} | Стіл: {TableNumber} | Статус: {Status} | Сума: {CalculateTotal()} грн | Позицій: {_orderItems.Count}";
        }

    }
}
