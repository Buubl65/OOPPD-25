using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        List<ISwitchable> switchables = new List<ISwitchable>();
        List<IEnergyConsumer> energyConsumer = new List<IEnergyConsumer>();

        public void AddDevice(ISwitchable device)
        {
            switchables.Add(device);
        }

        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyConsumer.Add(device);
        }

        public void TurnAllOn()
        {
            foreach(var device  in switchables)
            {
                device.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            foreach(var device in switchables)
            {
                device.TurnOff();
            }
        }

        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");

            double TotalEnergy = 0;

            foreach (var device in energyConsumer)
            {
                double energy = device.GetEnergyUsage(hours);
                TotalEnergy += energy;

                Console.WriteLine($"{device.DeviceName}: {energy:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
            }
            Console.WriteLine($"Загальне споживання: {TotalEnergy:F2} кВт·год");

            Console.WriteLine($"Вартість (~4 грн/кВт·год): {TotalEnergy * 4:F2} грн");
        }
    }
}
