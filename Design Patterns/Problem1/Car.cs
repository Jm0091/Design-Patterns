using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Car class extends IToy and used properties and have additional 3 propertites and 2 methods - Turning on lights and drive reverse 
    /// </summary>
    public class Car :IToy
    {
        public bool DoorOpens { get; set; }
        public bool RemoteControl { get; set; }
        public bool Chargeble { get; set; }
        public Car()
        {
            Cost = 5.99;
            Description = "** Small Red Car ** Makes your kid smarter thninking smartly from where to druve where! Let's drive my red car. **Small Red Car **";
            Name = "Small Red Car";
            ManufactureCompany = "Dadiv Inc.";
            ManufactureYear = "2021";
            MinimumAge = 2;
            MaximumAge = 10;
            ChokingHazard = true;
            Weight = 54.5;
            WeightUnit = "gram";

            DoorOpens = false;
            RemoteControl = false;
            Chargeble = false;
        }

        public string TurnOnLights()
        {
            if (RemoteControl && Chargeble)
                return "Lights On!";
            return "Sorry, Can not turn on lights.";
        }

        public void DriveReverse()
        {
            if (RemoteControl && Chargeble) {
                Console.WriteLine("Driving in Reverse");
            }
            Console.WriteLine($"Sorry, Can not drive car {Name} reverse.");

        }
    }
}
