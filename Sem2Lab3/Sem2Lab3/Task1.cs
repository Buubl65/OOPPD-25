using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab3
{
    class Task1
    {
        public static void Run()
        {
            Console.WriteLine("=== Завдання 1: Аналізатор текстового файлу ===");

            string inputPath = "story.txt";
            string outputPath = "report.txt";

            if (!File.Exists(inputPath))
            {
                File.WriteAllText(inputPath, "Hello World!\nThis is a sample story file.\nIt contains text for testing.");
            }

            int lineCount = 0;
            int wordCount = 0;
            int charCount = 0;

            using (StreamReader reader = new StreamReader(inputPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    charCount += line.Length;

                    string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    wordCount += words.Length;
                }
            }

            string reportText = $"Кількість рядків: {lineCount}\n" +
                               $"Кількість слів: {wordCount}\n" +
                               $"Кількість символів: {charCount}\n";

            File.WriteAllText(outputPath, reportText);

            Console.WriteLine("Аналіз завершено. Результати записано в report.txt:");
            Console.WriteLine(reportText);
        }
    }
}
