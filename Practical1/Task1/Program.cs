namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введіть число");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                string message = GetMessage(number);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Помилка. Введіть число");
            }
        }

        public static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }

        public static string GetMessage(int number)
        {
            return IsEven(number) ? "Двері відкриваються!" : "Двері зачинені...";
        }
    }
}