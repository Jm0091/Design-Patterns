using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// StuffedAnimal class extends IToy and used properties and have additional 3 propertites and 2 methods - for Tie button and for get Weight After Wash
    /// </summary>
    public class StuffedAnimal : IToy
    {
        public bool Washable { get; set; }
        public string MaterialUsed { get; set; }
        public int NumberofButtonsUsed { get; set; }
        public StuffedAnimal()
        {
            Cost = 10.00;
            Description = "Kid Connection Brown Cuddly Teddy Bear Plush Stuffed Animal Teddy is part of the Kid Connection family of plush animal friends available exclusively at Walmart Canada! Ready to play all day and snuggle all night, this 1 - inch super - cozy, Cuddly Teddy Bear plush has an oversized, huggable body covered in soft, curly fur fabric.Featuring embroidered paw - printed feet and a soft muzzle for nuzzling, Teddy comes complete with a warm smile and a cute, dapper bowtie that makes him oh - so - loveable.Available in three colours—brown, cream and camel—Teddy is appropriate for ages three and up.\nCare instructions: Surface - washable for easy cleaning. Fluff teddy when you bring him home.";
            Name = "Puppy Dog - Stuffed Animal";
            ManufactureCompany = "Melissa & Dong";
            ManufactureYear = "2021";
            MinimumAge = 5;
            MaximumAge = 12;
            ChokingHazard = false;
            Weight = 150;
            WeightUnit = "gram";

            Washable = true;
            MaterialUsed = "Terrycloth";
            NumberofButtonsUsed = 3;
        }
        public void TieButton(int leftNumOfBtns)
        {
            if (leftNumOfBtns < NumberofButtonsUsed && leftNumOfBtns >= 0)
            {
                NumberofButtonsUsed = 3;
                Console.WriteLine($"Now {Name} have all buttons{NumberofButtonsUsed}!");
            }
            else
            { 
                Console.WriteLine($"Now {Name} do not need to TieButtons!");
            }
        }

        public double GetWeightAfterWash()
        {
            if (Washable) {
                return Weight - 10;
            }
            return Weight;
        }
    }
}
