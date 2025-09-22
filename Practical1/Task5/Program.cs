namespace Task5
{
    public class Program
    {
        static void Main()
        {
            Random random = new Random();
            int RNumberOfGroup = random.Next(3, 6);


            int[][] groups = new int[RNumberOfGroup][];

            for (int i = 0; i < RNumberOfGroup; i++)
            {
                int RNumberOfStudent = random.Next(10, 30);
                groups[i] = new int[RNumberOfStudent];

                for (int j = 0; j < RNumberOfStudent; j++)
                {
                    groups[i][j] = random.Next(0, 101);
                }
            }

            PrintGroupStatistics(groups);
        }

        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks) sum += mark;
            return (double)sum / marks.Length;
        }

        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks) if (mark < min) min = mark;
            return min;
        }

        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks) if (mark > max) max = mark;
            return max;
        }

        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"Група {i+1}:");
                Console.WriteLine($"Середній бал: {GetAverage(groups[i]):F2}");
                Console.WriteLine($"Мінімальний бал: {GetMin(groups[i])}");
                Console.WriteLine($"Максимальний бал: {GetMax(groups[i])}");
                Console.WriteLine();
            }
        }


    }
}
