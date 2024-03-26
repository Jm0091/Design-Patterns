using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// RegularMotherboard Class extends MotherBoard Class and overrides abstract methods for Description and Cost
    ///     - It will be used to make object of MotherBoard for Computer
    /// </summary>
    public class RegularMotherboard : Motherboard
    {
        public RegularMotherboard(Computer computer):base(computer)
        {
            this.computer = computer;
        }
        public override string GetDescription()
        {
            return computer.GetDescription() + $"{computer.GetDescription()} \n\tMotherboard: Regular Motherboard";
        }
        public override double GetCost()
        {
            return computer.GetCost() + 299.99;
        }
    }
}
