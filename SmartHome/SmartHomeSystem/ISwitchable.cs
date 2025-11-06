using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public interface ISwitchable
    {
        public void TurnOn();
        public void TurnOff();
        bool IsOn { get; }
    }
}
