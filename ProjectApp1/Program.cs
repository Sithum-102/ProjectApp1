using System;

namespace RobotFactorySystem
{
    public abstract class Robot
    {
        public string ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        public abstract Robot Clone();

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Model: {ModelName}");
            Console.WriteLine($"Battery: {BatteryCapacity} hours");
            Console.WriteLine($"Software: {SoftwareVersion}");
        }
    }

    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n[ Service Robot Info ]");
            base.DisplayInfo();
            Console.WriteLine($"Task: {ServiceTask}");
        }
    }

    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n[ Industrial Robot Info ]");
            base.DisplayInfo();
            Console.WriteLine($"Task: {IndustrialTask}");
        }
    }

    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public override Robot Clone()
        {
            return (Robot)this.MemberwiseClone();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n[ Entertainment Robot Info ]");
            base.DisplayInfo();
            Console.WriteLine($"Feature: {EntertainmentFeature}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ServiceRobot srvRobot = new ServiceRobot
            {
                ModelName = "SR-Alpha",
                BatteryCapacity = 12,
                SoftwareVersion = "v1.0",
                ServiceTask = "Hospitality Assistance"
            };

            IndustrialRobot indRobot = new IndustrialRobot
            {
                ModelName = "IR-Titan",
                BatteryCapacity = 24,
                SoftwareVersion = "v2.5",
                IndustrialTask = "Welding"
            };

            srvRobot.DisplayInfo();
            indRobot.DisplayInfo();

            ServiceRobot clonedSrvRobot = (ServiceRobot)srvRobot.Clone();
            clonedSrvRobot.SoftwareVersion = "v1.2";
            clonedSrvRobot.ServiceTask = "Healthcare Assistance";
            clonedSrvRobot.DisplayInfo();

            IndustrialRobot clonedIndRobot = (IndustrialRobot)indRobot.Clone();
            clonedIndRobot.BatteryCapacity = 48;
            clonedIndRobot.IndustrialTask = "Car Assembly";
            clonedIndRobot.DisplayInfo();

            Console.ReadLine();
        }
    }
}