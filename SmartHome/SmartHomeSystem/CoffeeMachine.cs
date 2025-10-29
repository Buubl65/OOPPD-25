using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    class CoffeeMachine : Device, IEnergyConsumer
    {
        public const int Power = 1000;

        public CoffeeMachine(string name) : base(name) { }

        public string DeviceName => Name;
        public int PowerConsumption => Power;

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почав готувати каву");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} завершила роботу");
        }

        public double GetEnergyUsage(int hourse)
        {
            if (!IsOn)
            {
                return 0.0;
            }

            return PowerConsumption * hourse / 1000.0;
        }
    }
}
