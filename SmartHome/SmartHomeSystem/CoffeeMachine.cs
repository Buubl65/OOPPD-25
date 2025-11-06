using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public int Power = 1000;

        public CoffeeMachine(string name) : base(name) { }

        public string DeviceName => Name;

        public int PowerConsumption => Power;

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} почала готувати каву.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} завершила роботу.");
        }

        public double GetEnergyUsage(int hours)
        {
            if (!IsOn) { return 0; }
            return PowerConsumption * hours / 1000;
        }
    }
}
