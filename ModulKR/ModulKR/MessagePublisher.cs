using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulKR
{
    internal class MessagePublisher
    {
        public event Action<string> OnMessagePublished;
        public void Send(string message)
        {
            OnMessagePublished?.Invoke(message);
        }
    }
}
