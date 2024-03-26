using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// PersonalComputer Class extends MotherBoard Class and overrides abstract methods for Description and Cost
    ///     - It will be used to make object of PersonalComputer for Computer
    /// </summary>
    public class PersonalComputer : Computer
    {
        public PersonalComputer()
        {
            Description = "Personal Computer";
            Cost = 299.99;
        }
        public override string GetDescription()
        {
            return Description;
        }
        public override double GetCost()
        {
            return Cost;
        }
    }
}
