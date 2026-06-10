using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab1
{
    public class Logger
    {
        public Action<string> LogHandler { get; set; }

        public void Log(string message)
        {
            LogHandler?.Invoke(message);
        }
    }
}
