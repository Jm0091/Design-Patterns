using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// ComputerDecorator Class extends MotherBoard Class and overrides abstract methods for Description and Cost
    /// </summary>
    public abstract class ComputerDecorator : Computer
    {
        public Computer computer;

        public ComputerDecorator(Computer computer)
        {
            this.computer = computer;
        }

        public abstract override string GetDescription();

        public abstract override double GetCost();
    }
}
