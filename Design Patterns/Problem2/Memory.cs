using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Memory Class extends MotherBoard's Decorator Class and overrides abstract methods updates Description and Cost
    ///     - Properties checking for valid inputs and throws exception if required.
    /// </summary>
    class Memory : MotherboardDecorator
    {
        public int CapacityCount {
            get { return CapacityCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                CapacityCount = value;
            }
        }
        public string CapacityUnit
        {
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
        public string SpeedUnit
        {
            get { return CapacityUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
            }
        }
        public double ReadSpeedCount {
            get { return ReadSpeedCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                ReadSpeedCount = value;
            }
        }
        public double WriteSpeedCount {
            get { return WriteSpeedCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                WriteSpeedCount = value;
            }
        }
        public bool DDR1 {
            get { return DDR1; }
            set
            {
                if (value != true && value !=false)
                {
                    throw new ArgumentException();
                }
                DDR1 = value;
            }
        }
        public bool DDR2 {
            get { return DDR2; }
            set
            {
                if (value != true && value != false)
                {
                    throw new ArgumentException();
                }
                DDR2 = value;
            }
        }
        public bool DDR3 {
            get { return DDR3; }
            set
            {
                if (value != true && value != false)
                {
                    throw new ArgumentException();
                }
                DDR3 = value;
            }
        }
        public bool DDR4 {
            get { return DDR4; }
            set
            {
                if (value != true && value != false)
                {
                    throw new ArgumentException();
                }
                DDR4 = value;
            }
        }
        public Memory (Motherboard motherboard, Computer computer) : base(motherboard, computer)
        {
            CapacityCount = 8;
            CapacityUnit = "GB";
            SpeedUnit = "MB/s";
            ReadSpeedCount = 12.5;
            WriteSpeedCount = 12.5;
            DDR1 = false;
            DDR2 = false;
            DDR3 = true;
            DDR4 = false;
        }
        public override string GetDescription()
        {
            string CDRAM = "DDR4";
            if (DDR1){
                CDRAM = "DDR1";
            }else if (DDR2){
                CDRAM = "DDR2";
            }else if (DDR3){
                CDRAM = "DDR3";
            }
            return $"{motherboard.GetDescription()}\nMemory: Timetec \n\t(Info: Size:{CapacityCount}{CapacityUnit} (CDRAM: {CDRAM}), Speed - Read: {ReadSpeedCount} | Write: {WriteSpeedCount} ({SpeedUnit}))";
        }
        public override double GetCost()
        {
            return motherboard.GetCost() + 34.99;
        }
    }
}
