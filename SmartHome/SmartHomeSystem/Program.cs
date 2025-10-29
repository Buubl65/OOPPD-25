using System;

namespace SmartHomeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHomeController controller = new SmartHomeController();
            Light light = new Light("Лампа у вітальні");
            AirConditioner conditioner = new AirConditioner("Кондеціонер у спальні");
            CoffeeMachine coffeeMachine = new CoffeeMachine("Кавомашина на кухні");
            MotionSensor sensor = new MotionSensor("Датчик руху у коридорі");

            controller.AddDevice(light);
            controller.AddDevice(conditioner);
            controller.AddDevice(coffeeMachine);
            controller.AddDevice(sensor);

            controller.AddEnergyDevice(light);
            controller.AddEnergyDevice(conditioner);
            controller.AddEnergyDevice(coffeeMachine);

            controller.TurnAllOn();

            light.PrintStatus();
            conditioner.PrintStatus();
            coffeeMachine.PrintStatus();
            sensor.PrintStatus();

            controller.ShowEnergyReport(5);
            controller.TurnAllOff();
        }
    }
}
