using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab3
{
    class Task3
    {
        public static void Run(string path)
        {
            Console.WriteLine($"=== Завдання 3: Пошук найбільшого файлу в [{path}] ===");

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Помилка: Шлях не існує.");
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(path);

            FileInfo[] files = dir.GetFiles("*.*", SearchOption.AllDirectories);

            FileInfo largestFile = null;

            foreach (var file in files)
            {
                if (largestFile == null || file.Length > largestFile.Length)
                {
                    largestFile = file;
                }
            }

            if (largestFile != null)
            {
                Console.WriteLine($"Name: {largestFile.Name}");
                Console.WriteLine($"Size: {largestFile.Length} байт");
                Console.WriteLine($"Path: {largestFile.FullName}");
            }
            else
            {
                Console.WriteLine("У вказаній папці файлів не знайдено.");
            }
        }
    }
}
