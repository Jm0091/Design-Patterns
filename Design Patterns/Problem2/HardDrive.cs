using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// HardDrive Class extends MotherBoard's Decorator Class and overrides abstract methods updates Description and Cost
    ///     - Properties checking for valid inputs and throws exception if required.
    /// </summary>
    public class HardDrive : MotherboardDecorator
    {
        public int CapacityCount
        {
            get { return CapacityCount; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
                CapacityCount = value;
            }
        }
        public string CapacityUnit {
            get { return CapacityUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                CapacityUnit = value;
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
        public double ReadSpeedCount
        {
            get { return ReadSpeedCount; }
            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentException();
                }
                ReadSpeedCount = value;
            }
        }
        public double WriteSpeedCount
        {
            get { return WriteSpeedCount; }
            set
            {
                if (value < 0.1)
                {
                    throw new ArgumentException();
                }
                WriteSpeedCount = value;
            }
        }
        public bool IsSSD
        {
            get { return IsSSD; }
            set
            {
                if (value != true && value != false)
                {
                    throw new ArgumentException();
                }
                IsSSD = value;
            }
        }
        public bool IsHDD
        {
            get { return IsHDD; }
            set
            {
                if (value != true && value != false)
                {
                    throw new ArgumentException();
                }
                IsHDD = value;
            }
        }
        public HardDrive(Motherboard motherboard, Computer computer) : base(motherboard, computer)
        {
            CapacityCount = 2;
            CapacityUnit = "TB";
            SpeedUnit = "MB/s";
            ReadSpeedCount = 540;
            WriteSpeedCount = 540;
            IsSSD = true;
            IsHDD = false;
        }
        public override string GetDescription()
        {
            string type = "HDD";
            if (IsSSD) {
                type = "SSD";
            }
            return $"{motherboard.GetDescription()}\nHarddrive: Samsung Harddrive\n\t(Info: Size:{CapacityCount}{CapacityUnit} (Type: {type}), Speed - Read: {ReadSpeedCount} | Write: {WriteSpeedCount} ({SpeedUnit}))";

        }

        public override double GetCost()
        {
            return motherboard.GetCost() + 249.99;
        }
    }
}
