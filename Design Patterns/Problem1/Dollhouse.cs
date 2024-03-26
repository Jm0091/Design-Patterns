using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Dollhouse class extends IToy and used properties and have additional 3 propertites and 2 methods - for fold the house and open it 
    /// </summary>
    public class Dollhouse : IToy
    {
        public bool AutomaticFoldable { get; set; }
        public int NumberofRooms { get; set; }
        public int NumberofDolls { get; set; }
        public Dollhouse()
        {
            Cost = 155.99;
            Description = "Barbie Dreamhouse (3.75-Ft) Dollhouse With Pool, Slide, Elevator, Lights & Sounds. Measuring 43 inches tall and 41 inches wide, the fully furnished new Barbie Dreamhouse inspires endless imagination with 10 indoor and outdoor play areas, customizable features and 75+ storytelling pieces!";
            Name = "Barbie Dreamhouse";
            ManufactureCompany = "Barbie";
            ManufactureYear = "2022";
            MinimumAge = 3;
            MaximumAge = 13;
            ChokingHazard = false;
            Weight = 26.7;
            WeightUnit = "lb";

            AutomaticFoldable = true;
            NumberofRooms = 10;
            NumberofDolls = 3;
        }

        public void FoldIt() 
        {
            if(AutomaticFoldable)
                Console.WriteLine($"The {Name} is now getting fold automatically. Thank you!");
        }

        public void OpenIt()
        {
            if (AutomaticFoldable)
                Console.WriteLine($"Hello! The {Name} is now opening automatically.");
        }
    }
}
