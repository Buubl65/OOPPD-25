using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab2
{
    public class TemperatureChangeEventArgs : EventArgs
    {
        public double Temperature { get; }
        public TemperatureChangeEventArgs(double temperature) => Temperature = temperature;
    }

    public class TemperatureSensor
    {
        public event EventHandler<TemperatureChangeEventArgs> TemperatureChanged;

        private double _currentTemperature;

        public void SetTemperature(double newTemperature)
        {
            Console.WriteLine($"\n[Датчик]: Температура змінилася на {newTemperature}°C");
            _currentTemperature = newTemperature;

            TemperatureChanged?.Invoke(this, new TemperatureChangeEventArgs(_currentTemperature));
        }
    }

    public class Display
    {
        public void OnTemperatureChanged(object sender, TemperatureChangeEventArgs e)
        {
            Console.WriteLine($"[Display]: Поточна температура на екрані: {e.Temperature}°C");
        }
    }

    public class AirConditioner
    {
        public void OnTemperatureChanged(object sender, TemperatureChangeEventArgs e)
        {
            if (e.Temperature < 17)
                Console.WriteLine("[AirConditioner]: Увімкнено ОБІГРІВ");
            else if (e.Temperature >= 17 && e.Temperature <= 25)
                Console.WriteLine("[AirConditioner]: Кондиціонер ВИМКНЕНИЙ 💤");
            else
                Console.WriteLine("[AirConditioner]: Увімкнено ОХОЛОДЖЕННЯ ❄️");
        }
    }

    public class SecuritySystem
    {
        public void OnTemperatureChanged(object sender, TemperatureChangeEventArgs e)
        {
            if (e.Temperature > 40)
                Console.WriteLine("[SecuritySystem]: КРИТИЧНИЙ ПЕРЕГРІВ! Загроза пожежі!");
            else if (e.Temperature < 5)
                Console.WriteLine("[SecuritySystem]: РИЗИК ЗАМЕРЗАННЯ СИСТЕМ! Увага!");
        }
    }
}
