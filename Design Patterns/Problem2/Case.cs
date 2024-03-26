using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Case Class (Case of motherboard's body) extends ComputerDecorator Class and overrides abstract methods updates Descripion and Cost
    ///     - Properties checking for valid inputs and throws exception if required.
    /// </summary>
    public class Case : ComputerDecorator
    {
        public double Length {
            get { return Length; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
            }
        }
        public double Height {
            get { return Height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
            }
        }
        public double Width {
            get { return Width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
            }
        }
        public string DimensionUnit {
            get { return DimensionUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
            }
        }
        public int NumberOfFans {
            get { return NumberOfFans; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
            }
        }
        public int NumberOfVents {
            get { return NumberOfVents; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
            }
        }

        public Case(Computer computer) : base(computer)
        {
            Length = 468.8;
            Width = 454.5;
            Height = 200;
            DimensionUnit = "mm";
            NumberOfFans = 1;
            NumberOfVents = 1;
        }
        public override double GetCost()
        {
            return computer.GetCost() + 88.32;
        }
        public override string GetDescription()
        {
            return $"{computer.GetDescription()}\nCase: MasterBox Lite 5 RGB \n\t(Info: Dimensions(in {DimensionUnit}): {Length}x{Width}x{Height} (LxWxD), Case has {NumberOfFans} fan/s and {NumberOfVents} vent/s. )";
        }
    }
}
