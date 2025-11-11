using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public int PowerConsumption => 1000;

        public string DeviceName => Name;

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} почала готувати каву.");
            IsOn = true;
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} завершила роботу.");
            IsOn = false;
        }

        public double GetEnergyUsage(int hours)
        {
            if(!IsOn) return 0;
            return PowerConsumption * hours / 1000.0;
        }
    }
}
