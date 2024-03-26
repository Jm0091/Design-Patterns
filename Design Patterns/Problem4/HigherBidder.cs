using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    /// <summary>
    /// This Class contain Concrete implementation of IBidder with  maximum limit of 200.00
    /// </summary>
    public class HigherBidder : IBidder
    {
        public string Name { get; set; }
        public HigherBidder(string name)
        {
            Name = name;
        }

        public double getMaximumLimit()
        {
            return 200.00;
        }

        public string getName()
        {
            return Name;
        }

        public void Notify(string announcment)
        {
            Console.WriteLine($"{Name} is notified: \n\t {announcment}");
        }
    }
}
