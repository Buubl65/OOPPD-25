using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class MotionSensor : Device
    {
        public MotionSensor(string name) : base(name) { }

        public override void TurnOn()
        {
            Console.WriteLine($"{Name} активовано.");
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} деактивовано.");
        }

    }
}
