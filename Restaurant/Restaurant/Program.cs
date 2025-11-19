using System.Text;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Restaurant restaurant = new Restaurant();

            Console.WriteLine("--- СИСТЕМА РЕСТОРАНУ ЗАПУЩЕНА ---\n");

            restaurant.Menu.AddDish(new Dish(0, "Борщ Український", 85.0m, Category.Soup));
            restaurant.Menu.AddDish(new Dish(0, "Стейк Рібай", 350.50m, Category.MainCourse));
            restaurant.Menu.AddDish(new Dish(0, "Салат Цезар", 120.00m, Category.Salad));
            restaurant.Menu.AddDrink(new Drink(0, "Кока-Кола", 30.00m, 330, false, Category.Drink));
            restaurant.Menu.AddDrink(new Drink(0, "Пиво 'Львівське'", 55.00m, 500, true, Category.Drink));
            restaurant.Menu.AddDish(new Dish(0, "Тірамісу", 95.00m, Category.Dessert));

            Console.WriteLine("Меню успішно сформовано.");

            Console.WriteLine(restaurant.Menu.GetAll());

            // Замовлення 1 (Стіл 5)
            Order order1 = restaurant.CreateOrder(5);
            Console.WriteLine($"Створено замовлення {order1.Id} для столу {order1.TableNumber}.");
            var steak = restaurant.Menu.FindById(2);
            var cola = restaurant.Menu.FindById(4);

            order1.AddItem(steak);
            order1.AddItem(cola);

            Console.WriteLine(order1.OrderInfo());

            order1.SetStatus(OrderStatus.Confirmed);
            Console.WriteLine($"Статус замовлення {order1.Id} змінено на {order1.Status}.");

            // Замовлення 2 (Стіл 2)
            Order order2 = restaurant.CreateOrder(2);
            Console.WriteLine($"Створено замовлення {order2.Id} для столу {order2.TableNumber}.");
            var borsch = restaurant.Menu.FindById(1);
            var beer = restaurant.Menu.FindById(5); 

            order2.AddItem(beer);
            order2.AddItem(beer);
            order2.AddItem(borsch);

            Console.WriteLine(order2.OrderInfo());

            order2.SetStatus(OrderStatus.InProgress);
            Console.WriteLine($"Статус замовлення {order2.Id} змінено на {order2.Status}.");

            Console.WriteLine(order2.OrderInfo());
            Console.WriteLine("----------------------------");

            // Видалення елемента з Замовлення 2
            order2.RemoveItemByMenuId(5);
            Console.WriteLine($"Видалено Пиво з #{order2.Id}.");
            Console.WriteLine(order2.OrderInfo());
            Console.WriteLine("----------------------------");

            // Перегляд активних замовлень
            Console.WriteLine("Активні Замовлення:");
            Console.WriteLine(restaurant.GetActiveOrders());
            Console.WriteLine("----------------------------");
        }
    }
}
