namespace Task2
{
    public class Program
    {
        public static void Main()
        {

        }
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] numbers = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(min, max);
            }
            return numbers;
        }

        public static int GetSum(int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public static double GetAverage(int[] numbers)
        {
            double result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            result /= numbers.Length;
            return result;
        }

        public static int GetMin(int[] numbers)
        {
            int result = numbers[0];
            foreach (int number in numbers) if (number < result) result = number;
            return result; 
        }

        public static int GetMax(int[] numbers)
        {
            int result = numbers[0];
            foreach (int number in numbers) if (number > result) result = number;
            return result;
        }
    }
}