using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class MotionSensor : Device
    {
        public override void TurnOn()
        {
            Console.WriteLine($"{Name} активовано.");
            IsOn = true;
        }

        public override void TurnOff()
        {
            Console.WriteLine($"{Name} деактивовано.");
            IsOn = false;
        }
    }
}
