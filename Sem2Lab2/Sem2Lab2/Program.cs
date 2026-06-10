namespace Sem2Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== СИСТЕМА КЛІМАТ-КОНТРОЛЮ ===");

            TemperatureSensor sensor = new TemperatureSensor();

            Display display = new Display();
            AirConditioner ac = new AirConditioner();
            SecuritySystem security = new SecuritySystem();

            sensor.TemperatureChanged += display.OnTemperatureChanged;
            sensor.TemperatureChanged += ac.OnTemperatureChanged;
            sensor.TemperatureChanged += security.OnTemperatureChanged;

            sensor.SetTemperature(20); 
            sensor.SetTemperature(12); 
            sensor.SetTemperature(30); 
            sensor.SetTemperature(45); 
            sensor.SetTemperature(3);

            Console.WriteLine("=== ІГРОВА СИСТЕМА ОБРОБКИ УРОНУ ===");

            Player player = new Player();

            UIHealthBar healthBar = new UIHealthBar();
            SoundSystem sound = new SoundSystem();
            AchievementSystem achievements = new AchievementSystem();
            GameLogger logger = new GameLogger();

            player.OnDamageTaken += healthBar.OnPlayerDamage;
            player.OnDamageTaken += sound.OnPlayerDamage;
            player.OnDamageTaken += achievements.OnPlayerDamage;
            player.OnDamageTaken += logger.OnPlayerDamage;

            player.TakeDamage(15); 
            player.TakeDamage(40); 
            player.TakeDamage(30); 
            player.TakeDamage(20); 
        }
    }
}
