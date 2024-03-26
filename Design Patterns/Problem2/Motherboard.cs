using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Motherboard Class extends Computer's Decorator Class and overrides abstract methods for Description and Cost
    ///     - Properties checking for valid inputs and throws exception if required.
    /// </summary>
    public class Motherboard : ComputerDecorator
    {
        public int NumberOfMemorySlot
        {
            get { return NumberOfMemorySlot; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                NumberOfMemorySlot = value;
            }
        }
        public int PowerConsumptiomCount
        {
            get { return PowerConsumptiomCount; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                PowerConsumptiomCount = value;
            }
        }
        public string PowerConsumtionUnit
        {
            get { return PowerConsumtionUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                PowerConsumtionUnit = value;
            }
        }
        public int NumberOfPCISlots
        {
            get { return NumberOfPCISlots; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                NumberOfPCISlots = value;
            }
        }
        public string FormFactor
        {
            get { return FormFactor; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                FormFactor = value;
            }
        }

        public Motherboard(Computer computer) : base(computer)
        {
            NumberOfMemorySlot = 4;
            PowerConsumptiomCount = 60;
            PowerConsumtionUnit = "Watt";
            NumberOfPCISlots = 3;
            FormFactor = "Mini-ITX";
        }

        public override double GetCost()
        {
            return computer.GetCost() + 133.01;
        }

        public override string GetDescription()
        {
            return $"{computer.GetDescription()}\nMotherBoard: ASRock \n\t(Info: Memory Slots: {NumberOfMemorySlot}, Power: {PowerConsumptiomCount} {PowerConsumtionUnit}, Form Factor: {FormFactor})";
        }
    }
}
