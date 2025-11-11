namespace SmartHomeSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SmartHomeController controller = new SmartHomeController();

            Light light = new Light() { Name = "Лампа у вітальні" };
            AirConditioner conditioner = new AirConditioner() { Name = "Кондиціонер у спальні" };
            CoffeeMachine machine = new CoffeeMachine() { Name = "Кавомашина на кухні" };
            MotionSensor sensor = new MotionSensor() { Name = "Датчик руху у коридорі" };

            controller.AddDevice(light);
            controller.AddDevice(conditioner);
            controller.AddDevice(machine);
            controller.AddDevice(sensor);


            controller.AddEnergyDevice(light);
            controller.AddEnergyDevice(conditioner);
            controller.AddEnergyDevice(machine);

            controller.TurnAllOn();
            
            light.PrintStatus();
            conditioner.PrintStatus();
            machine.PrintStatus();
            sensor.PrintStatus();

            controller.ShowEnergyReport(5);

            controller.TurnAllOff();
        }
    }
}