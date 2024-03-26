using System;

namespace Problem2
{
    /// <summary>
    /// Computer Abstract Class have Cost and Description abstract methods for Description and Cost
    ///     - Properties checking for valid inputs and throws exception if required.
    ///     
    /// I Jems Chaudhary certify that it is my original work. No other person's work has been used without due acknowledgement.
    /// </summary>
    public abstract class Computer
    {
        public string Description {
            get { return Description; }
            set
            {
                if (value.Equals(""))
                {
                    throw new ArgumentException();
                }
                Description = value;
            }
        }
        public double Cost
        {
            get { return Cost; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                Cost = value;
            }
        }
        public abstract double GetCost();
        public abstract string GetDescription();
    }
}
