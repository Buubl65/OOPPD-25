using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class Light : Device, IEnergyConsumer
    {

        public string DeviceName => Name;

        public int PowerConsumption => 60;
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} засвітилася.");
            IsOn = true;
        }
        public override void TurnOff()
        {
            Console.WriteLine($"{Name} вимкнена.");
            IsOn = false;  
        }
        public double GetEnergyUsage(int hours)
        {
            if(!IsOn) return 0;
            return PowerConsumption * hours / 1000.0;
        }
    }
}
