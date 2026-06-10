namespace Sem2Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testPath = @"C:\TestFolder";

            // Завдання 1
            Task1.Run();

            // Завдання 2
            Task2.Run(testPath);

            // Завдання 3
            Task3.Run(testPath);

            // Завдання 4 (Варіант без рекурсії)
            Task4.CleanWithoutRecursion(testPath);

            // Завдання 5: Працює з CLI аргументами. 
            string[] cliArgs = { @"C:\TestFolder" };
            Task5.Execute(cliArgs);
        }
    }
}
