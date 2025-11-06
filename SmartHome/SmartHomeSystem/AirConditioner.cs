using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class AirConditioner : Device, IEnergyConsumer
    {
        public int Power = 2000;

        public AirConditioner(string name) : base(name) { }

        public string DeviceName => Name;
        public int PowerConsumption => Power;

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} почав охолодження.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} зупинено.");
        }

        public double GetEnergyUsage(int hours)
        {
            if (!IsOn) { return 0; }
            return PowerConsumption * hours / 1000;
        }

    }
}
