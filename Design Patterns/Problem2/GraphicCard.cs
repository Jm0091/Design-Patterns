using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// GraphicCard Class extends MotherBoard's Decorator Class and overrides abstract methods updates Descripion and Cost
    ///     - Properties checking for valid inputs and throws exception if required.
    /// </summary>
    public class GraphicCard : MotherboardDecorator
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
        public int VideoMemoryCount {
            get { return VideoMemoryCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                VideoMemoryCount = value;
            }
        }
        public string VideoMemoryUnit {
            get { return VideoMemoryUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                VideoMemoryUnit = value;
            }
        }
        public string MemorySpeedUnit {
            get { return MemorySpeedUnit; }
            set
            {
                if (value != null || value.Equals(""))
                {
                    throw new ArgumentException();
                }
                MemorySpeedUnit = value;
            }
        }
        public double MemorySpeed {
            get { return MemorySpeed; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException();
                }
                MemorySpeed = value;
            }
        }
        public int CUDACores {
            get { return CUDACores; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                CUDACores = value;
            }
        }
        public GraphicCard(Motherboard motherboard, Computer computer) : base(motherboard, computer)
        {
            CapacityCount = 6;
            CapacityUnit = "GB";
            CUDACores = 1280;
            MemorySpeedUnit = "MHz";
            MemorySpeed = 14000;
            VideoMemoryCount = 8;
            VideoMemoryUnit = "GB";
        }
        public override string GetDescription()
        {
            return $"{motherboard.GetDescription()}\nGraphicCard: Gigabyte GeForce GTX 1660 Super Mini \n\t(Info: Size:{CapacityCount}{CapacityUnit}, Video Memory: {VideoMemoryCount}{VideoMemoryUnit}. Speed: {MemorySpeed}({MemorySpeedUnit}), CUDA Cores: {CUDACores})";
        }
        public override double GetCost()
        {
            return motherboard.GetCost() + 1193.45;
        }
    }
}
