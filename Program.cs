using System;

namespace SmartHomeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartHomeController controller = new SmartHomeController();

            Light light = new Light { Name = "Лампа у вітальні" };
            AirConditioner ac = new AirConditioner { Name = "Кондиціонер у спальні" };
            CoffeeMachine coffeeMachine = new CoffeeMachine { Name = "Кавомашина на кухні" };
            MotionSensor motionSensor = new MotionSensor { Name = "Датчик руху у коридорі" };

            controller.AddDevice(light);
            controller.AddDevice(ac);
            controller.AddDevice(coffeeMachine);
            controller.AddDevice(motionSensor);

            controller.AddEnergyDevice(light);
            controller.AddEnergyDevice(ac);
            controller.AddEnergyDevice(coffeeMachine);

            controller.TurnAllOn();
            Console.WriteLine();

            light.PrintStatus();
            ac.PrintStatus();
            coffeeMachine.PrintStatus();
            motionSensor.PrintStatus();
            Console.WriteLine();

            controller.ShowEnergyReport(5);
            Console.WriteLine();

            controller.TurnAllOff();
        }
    }
}