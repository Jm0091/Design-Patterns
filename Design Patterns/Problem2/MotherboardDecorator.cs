using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// MotherboardDecorator Class extends MotherBoard Class and overrides abstract methods for Description and Cost
    /// </summary>
    public abstract class MotherboardDecorator : Motherboard
    {
        public Motherboard motherboard;
        public Computer Computer;
        public MotherboardDecorator(Motherboard motherboard, Computer computer):base(computer)
        {
            this.computer = computer;
            this.motherboard = motherboard;
        }
        public abstract override string GetDescription();
        public abstract override double GetCost();
    }
}
