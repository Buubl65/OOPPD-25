using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab3
{
    class Task5
    {
        public static void Execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Помилка: Будь ласка, вкажіть шлях до папки як аргумент.");
                Console.WriteLine("Приклад: analyzer.exe C:\\Test");
                return;
            }

            string targetPath = args[0];

            if (!Directory.Exists(targetPath))
            {
                Console.WriteLine($"Помилка: Шлях '{targetPath}' не існує.");
                return;
            }

            DirectoryInfo rootDir = new DirectoryInfo(targetPath);

            DirectoryInfo[] allFolders = rootDir.GetDirectories("*.*", SearchOption.AllDirectories);
            FileInfo[] allFiles = rootDir.GetFiles("*.*", SearchOption.AllDirectories);

            long totalSize = 0;
            FileInfo largestFile = null;

            foreach (var file in allFiles)
            {
                totalSize += file.Length;

                if (largestFile == null || file.Length > largestFile.Length)
                {
                    largestFile = file;
                }
            }

            double totalSizeInMB = (double)totalSize / (1024 * 1024);

            Console.WriteLine($"Folders: {allFolders.Length}");
            Console.WriteLine($"Files: {allFiles.Length}");
            Console.WriteLine($"Total size: {totalSizeInMB:F1} MB");
            Console.WriteLine($"Largest file: {(largestFile != null ? largestFile.Name : "Немає файлів")}");
        }
    }
}
