using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab3
{
    class Task2
    {
        public static void Run(string path)
        {
            Console.WriteLine($"=== Завдання 2: Інспектор папки [{path}] ===");

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Помилка: Вказаний шлях не існує.");
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(path);

            Console.WriteLine("\n--- Підпапки ---");
            DirectoryInfo[] subDirs = dir.GetDirectories();
            foreach (var subDir in subDirs)
            {
                Console.WriteLine($"[Папка] {subDir.Name}");
            }

            Console.WriteLine("\n--- Файли ---");
            FileInfo[] files = dir.GetFiles();
            foreach (var file in files)
            {
                Console.WriteLine($"Файл: {file.Name}");
                Console.WriteLine($"  Розмір: {file.Length} байт");
                Console.WriteLine($"  Дата створення: {file.CreationTime}");
                Console.WriteLine();
            }
        }
    }
}
