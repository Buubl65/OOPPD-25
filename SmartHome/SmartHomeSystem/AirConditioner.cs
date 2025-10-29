using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    class AirConditioner : Device, IEnergyConsumer
    {
        public const int Power = 2000;

        public AirConditioner(string name) : base(name) { }

        public string DeviceName => Name;
        public int PowerConsumption => Power;

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почав охолоджувати");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} зупинено");
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
