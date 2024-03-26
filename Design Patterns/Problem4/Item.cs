using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    /// <summary>
    /// This abstract class represent an item that can be paced in an aution.
    /// </summary>
    public class Item
    {
        public string Name { get; set; }
        public double InitialPrice { get; set; }
        public int YearOfCreation { get; set; }
        public double SoldPrice { get; set; } 
    }
}
