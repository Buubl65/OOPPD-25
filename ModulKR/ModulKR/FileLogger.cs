using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulKR
{
    internal class FileLogger
    {
        private string _path;

        public FileLogger(string path, MessagePublisher publisher)
        {
            _path = path;

            publisher.OnMessagePublished += OnMessageSent;
        }

        private void OnMessageSent(string message)
        {
            string log = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

            File.AppendAllText(_path, log + Environment.NewLine);
        }
    }
}
