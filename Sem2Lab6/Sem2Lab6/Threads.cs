using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab6
{
    class Threads
    {
        private static readonly object _lockObject = new object();

        private static int _counter = 0;
        private static bool _isPaused = false;
        private static bool _isRunning = true;
        private static ConsoleColor _currentTextColor = ConsoleColor.White;

        public static void Run()
        {
            Console.WriteLine("=== Програма запущена ===");
            Console.WriteLine("Бінди: [P] - Пауза/Старт | [R] - Скидання | [C] - Зміна кольору | [Q] - Вихід\n");

            Thread inputThread = new Thread(ListenToKeys)
            {
                IsBackground = true 
            };
            inputThread.Start();

            while (true)
            {
                lock (_lockObject)
                {
                    if (!_isRunning) break;

                    if (!_isPaused)
                    {
                        _counter++;
                        Console.ForegroundColor = _currentTextColor;
                        Console.WriteLine($"Counter: {_counter}");
                        Console.ResetColor();
                    }
                }

                Thread.Sleep(1000);
            }

            Console.WriteLine("\nПрограму успішно завершено.");
        }

        private static void ListenToKeys()
        {
            ConsoleColor[] colors = { ConsoleColor.White, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.Yellow, ConsoleColor.Magenta };
            int colorIndex = 0;

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                lock (_lockObject)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.P:
                            _isPaused = !_isPaused;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine(_isPaused ? "[Система]: Лічильник на ПАУЗІ" : "[Система]: Лічильник ВІДНОВЛЕНО");
                            Console.ResetColor();
                            break;

                        case ConsoleKey.R:
                            _counter = 0;
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("[Система]: Лічильник СКИНУТО до 0");
                            Console.ResetColor();
                            break;

                        case ConsoleKey.C:
                            colorIndex = (colorIndex + 1) % colors.Length;
                            _currentTextColor = colors[colorIndex];
                            break;

                        case ConsoleKey.Q:
                            _isRunning = false;
                            return; 
                    }
                }
            }
        }
    }
}

