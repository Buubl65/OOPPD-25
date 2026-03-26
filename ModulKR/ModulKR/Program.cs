namespace ModulKR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "textPD25.txt";
            string outputPath = "output.txt";

            File.WriteAllText(outputPath, string.Empty);

            ProcessFile processFile = new ProcessFile();
            TextOperation textOperation = new TextOperation();

            File.AppendAllText(outputPath, "UPPERCASE" + Environment.NewLine);
            processFile.Process(filePath, outputPath, textOperation.ToUpperCase);

            File.AppendAllText(outputPath, "CHARACTER COUNT" + Environment.NewLine);
            processFile.Process(filePath, outputPath, textOperation.CountCharacters);

            File.AppendAllText(outputPath, "WORD COUNT" + Environment.NewLine);
            processFile.Process(filePath, outputPath, textOperation.CountWords);

            Console.WriteLine($"{outputPath}");

            //___---------------------task 2 -----------------//

            string logFile = "logPD25.txt";

            File.WriteAllText(logFile, string.Empty);

            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger(logFile, publisher);

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введи текст: ");
                string input = Console.ReadLine();

                publisher.Send(input);
            }

            Console.WriteLine("Готово! Перевір файл logPD2X.txt");
        }
    }
}
