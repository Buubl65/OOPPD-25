using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class AirConditioner : Device, IEnergyConsumer
    {
        public int PowerConsumption => 2000;
        public string DeviceName => Name;

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} почав охолодження.");
            IsOn = true;   
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} зупинено.");
            IsOn = false;
        }

        public double GetEnergyUsage(int hours)
        {
            if (!IsOn) return 0;
            return PowerConsumption * hours / 1000.0;
        }
    }
}
