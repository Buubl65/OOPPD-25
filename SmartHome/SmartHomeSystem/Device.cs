using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public abstract class Device : ISwitchable
    {
        public string Name { get; set; }
        public bool IsOn { get; protected set; }

        public Device(string name)
        {
            Name = name;
            IsOn = false;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();

        public void PrintStatus()
        {
            Console.WriteLine(IsOn ? $"{Name}: увімкнено" : $"{Name}: вимкнено");
        }
    }
}
