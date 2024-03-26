using System;

namespace Problem1
{
    /// <summary>
    /// IToy abstract class have property for any Toy (Used for Factory Pattern)
    ///     
    /// I Jems Chaudhary certify that it is my original work. No other person's work has been used without due acknowledgement.
    /// 
    /// </summary>
    public abstract class IToy
    {
        public double Cost { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string ManufactureCompany { get; set; }
        public string ManufactureYear { get; set; }
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public bool ChokingHazard { get; set; }
        public double Weight { get; set; }
        public string WeightUnit { get; set; }
    }
}
