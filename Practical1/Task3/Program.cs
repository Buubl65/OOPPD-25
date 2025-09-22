namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введіть ваш вік");
            string Text = Console.ReadLine();
            if (int.TryParse(Text, out int age))
            {
                string expected = ClassifyAge(age);
                Console.WriteLine(expected);
            }
            else
            {
                Console.WriteLine("Помилка. Введіть ваш вік");
            }
        }
        public static string ClassifyAge(int age)
        {
            switch (age)
            {
                case >= 0 and < 12:
                    return "Ви дитина";
                    break;

                case >= 12 and <= 17:
                    return "Підліток";
                    break;
                case >= 18 and <= 59:
                    return "Дорослий";
                    break;
                case >= 60 and <= 120:
                    return "Пенсіонер";
                    break;
                default:
                    return "Нереальний вік";

            }
        }
    }
}