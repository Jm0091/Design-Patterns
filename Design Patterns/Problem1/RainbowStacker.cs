using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// RainbowStacker class extends IToy and used properties and have additional 3 propertites and 2 methods - reqesting re-paint and to get Correct way
    /// </summary>
    public class RainbowStacker : IToy
    {
        public int TotalNumberOfItems { get; set; }
        public string ColorPattern { get; set; }
        public string RodType { get; set; }
        public RainbowStacker()
        {
            Cost = 25.99;
            Description = "Rainbow arch bridge design. Varying ways to play with, can be used as building block, stimulate imagination and develop creativity and help develop intelligence. Wooden Rainbow Nesting Blocks is multi - functional, versatile open-ended, and environmental protection paint covered.Colorful building block toys set contains 7 different vibrantly colored wooden pieces with separate sizes. \nThis Wooden Rainbow Stacking Game made out of a really pretty wood no hase bad smell and very smooth to the touch.With 7 different shaped &color wooden pieces, coupled together into a rainbow shape, this toy set introduces a certain amount of realism that your kids will absolutely be fascinated with!";
            Name = "KanCai Wooden Rainbow Stacker";
            ManufactureCompany = "KanCai";
            ManufactureYear = "2021";
            MinimumAge = 3;
            MaximumAge = 10;
            ChokingHazard = false;
            Weight = 15;
            WeightUnit = "oz";

            TotalNumberOfItems = 8;
            ColorPattern = "Nylon Rainbow Color";
            RodType = "Wooden";
        }

        public string CorrectWay()
        {
            string answer = "Step 1. Set up the wooden base and rode";
            answer += "Step 2. Start from Bigger Plate in following sequence: ";
            answer += "  Violet, Indigo, Vlue, Green, Yellow, Orange, Red";
            answer += "Step 3. Hooray! you are Done";
            return answer;
        }

        public void RequestForRePaint(bool request)
        { 
            if(request)
            {
                Console.WriteLine($"Here is you {Name} re-painted!");
            }
        }
    }
}
