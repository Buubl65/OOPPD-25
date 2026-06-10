using static Sem2Lab1.Task1;
using static Sem2Lab1.Task2;
using static Sem2Lab1.Task3;

namespace Sem2Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Завдання 1: Калькулятор ===");

            MathOperation op;

            op = Add;
            Console.WriteLine($"Додавання: 10 + 5 = {op(10, 5)}");

            op = Subtract;
            Console.WriteLine($"Віднімання: 10 - 5 = {op(10, 5)}");

            op = Multiply;
            Console.WriteLine($"Множення: 10 * 5 = {op(10, 5)}");

            op = Divide;
            Console.WriteLine($"Ділення: 10 / 5 = {op(10, 5)}");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("=== Завдання 2: Мультикастинг ===");

            NotificationHandler notifier = SendEmail;
            notifier += SendSMS;

            Console.WriteLine("Викликаємо делегат один раз:");
            notifier("Ваш запис підтверджено!");

            Console.WriteLine("--------------------------");

            Console.WriteLine("=== Завдання 3: Фільтрація списку ===");
            FilterPredicate s;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.Write("Парні числа: ");
            FilterArray(numbers, IsEven);

            Console.Write("Числа більше 5: ");
            FilterArray(numbers, IsGreaterThan5);

            Console.Write("Непарні числа (лямбда): ");
            FilterArray(numbers, n => n % 2 != 0);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("=== Завдання 4: Використання Func та Predicate ===");

            Func<double, double, double> calc;

            calc = (a, b) => a + b;
            Console.WriteLine($"Func Додавання: 20 + 10 = {calc(20, 10)}");

            calc = (a, b) => a - b;
            Console.WriteLine($"Func Віднімання: 20 - 10 = {calc(20, 10)}");

            calc = (a, b) => a * b;
            Console.WriteLine($"Func Множення: 20 * 10 = {calc(20, 10)}");

            calc = (a, b) => b != 0 ? a / b : throw new DivideByZeroException();
            Console.WriteLine($"Func Ділення: 20 / 10 = {calc(20, 10)}");


            Console.WriteLine("\n--- Фільтрація студентів через Predicate ---");

            List<string> students = new List<string> { "Андрій", "Богдан", "Анна", "Дмитро", "Аліна", "Олена" };

            char searchLetter = 'А';

            List<string> filteredStudents = students.FindAll(name => name.StartsWith(searchLetter));

            Console.WriteLine($"Студенти, що починаються на букву '{searchLetter}':");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"- {student}");
            }

            Console.WriteLine("=== Завдання 5: Логування ===");

            Logger logger = new Logger();

            logger.LogHandler = msg => Console.WriteLine($"[Console]: {msg}");
            logger.Log("Система успішно запустилася.");

            logger.LogHandler = msg => Console.WriteLine($"[UPPERCASE]: {msg.ToUpper()}");
            logger.Log("увага! зафіксовано критичну помилку!");

            Console.WriteLine("=== Завдання 6: Динамічний валідатор ===");

            Validator passwordValidator = Task6.GetValidator(8); 
            Validator loginValidator = Task6.GetValidator(3);    

            string userLogin = "Hi";
            string userPassword = "SecretPassword2026";

            Console.WriteLine($"Логін '{userLogin}' валідний? -> {loginValidator(userLogin)}");

            Console.WriteLine($"Пароль '{userPassword}' валідний? -> {passwordValidator(userPassword)}");
        }
    }
}
