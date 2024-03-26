using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// CPU Class extends MotherBoard's Decorator Class and overrides abstract methods for Description and Cost
    ///     - Properties checking for valid inputs and throws exception if required.
    /// </summary>
    public class CPU : MotherboardDecorator
    {
        public double SpeedCount {
            get { return SpeedCount; }
            set 
            {
                if (value < 0.1)
                {
                    throw new ArgumentException();
                }
                SpeedCount = value;
            }
        }
        public string SpeedUnit {
            get { return SpeedUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                SpeedUnit = value;
            }
        }
        public string Manufacturer
        {
            get { return Manufacturer; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                Manufacturer = value;
            }
        }
        public double CacheSizeCount {
            get { return CacheSizeCount; }
            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentException();
                }
                CacheSizeCount = value;
            }
        }
        public string CacheSizeUnit
        {
            get { return CacheSizeUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                CacheSizeUnit = value;
            }
        }
        public int NumberOfCores {
            get { return NumberOfCores; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                NumberOfCores = value;
            }
        }
        public CPU(Motherboard motherboard, Computer computer) : base(motherboard, computer)
        {
            SpeedCount = 4.3;
            SpeedUnit = "GHz";
            Manufacturer = "Intel";
            CacheSizeCount = 1.5;
            CacheSizeUnit = "MB";
            NumberOfCores = 6;
        }
        public override string GetDescription()
        {
            return $"{motherboard.GetDescription()}\nCPU: Samsung Harddrive\n\t(Info: Speed:{SpeedCount}{SpeedUnit} ({NumberOfCores} Cores), Manufacturer: {Manufacturer}, Cache Count: {CacheSizeCount}{CacheSizeUnit})";
        }
        public override double GetCost()
        {
            return motherboard.GetCost() + 169.99;
        }
    }
}
