using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab3
{
    class Task4
    {
        public class CleanReport
        {
            public int FilesDeleted { get; set; } = 0;
            public long TotalSizeDeleted { get; set; } = 0;
        }

        public static void CleanWithRecursion(string cachePath)
        {
            Console.WriteLine($"=== Завдання 4: Очищення кешу (РЕКУРСІЯ) в [{cachePath}] ===");
            if (!Directory.Exists(cachePath)) return;

            CleanReport report = new CleanReport();

            ExecuteRecursion(new DirectoryInfo(cachePath), report);

            Console.WriteLine($"Видалено файлів: {report.FilesDeleted}");
            Console.WriteLine($"Сумарний розмір: {report.TotalSizeDeleted} байт");
        }

        private static void ExecuteRecursion(DirectoryInfo currentDir, CleanReport report)
        {
            foreach (FileInfo file in currentDir.GetFiles())
            {
                report.TotalSizeDeleted += file.Length;
                file.Delete();
                report.FilesDeleted++;
            }

            foreach (DirectoryInfo subDir in currentDir.GetDirectories())
            {
                ExecuteRecursion(subDir, report);
            }
        }


        public static void CleanWithoutRecursion(string cachePath)
        {
            Console.WriteLine($"=== Завдання 4: Очищення кешу (БЕЗ РЕКУРСІЇ) в [{cachePath}] ===");
            if (!Directory.Exists(cachePath)) return;

            CleanReport report = new CleanReport();
            Queue<DirectoryInfo> foldersQueue = new Queue<DirectoryInfo>();

            foldersQueue.Enqueue(new DirectoryInfo(cachePath));

            while (foldersQueue.Count > 0)
            {
                DirectoryInfo currentDir = foldersQueue.Dequeue();

                foreach (FileInfo file in currentDir.GetFiles())
                {
                    report.TotalSizeDeleted += file.Length;
                    file.Delete();
                    report.FilesDeleted++;
                }

                foreach (DirectoryInfo subDir in currentDir.GetDirectories())
                {
                    foldersQueue.Enqueue(subDir);
                }
            }

            Console.WriteLine($"Видалено файлів: {report.FilesDeleted}");
            Console.WriteLine($"Сумарний розмір: {report.TotalSizeDeleted} байт");
        }
    }
}

