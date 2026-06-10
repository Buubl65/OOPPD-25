using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab1
{
    class Task2
    {
        public delegate void NotificationHandler(string message);

        public static void SendEmail(string message)
        {
            Console.WriteLine($"[Email] {message}");
        }

        public static void SendSMS(string message) => Console.WriteLine($"SMS sent: [{message}]");
    }
}
