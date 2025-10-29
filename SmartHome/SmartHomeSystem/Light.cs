using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSystem
{
    public class Light: Device, IEnergyConsumer
    {
        public const int Power = 60;

        public Light(string name) : base(name) { }

        public string DeviceName => Name;
        public int PowerConsumption => Power;

        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} засвітилася");
        }
        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} погасла");
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
