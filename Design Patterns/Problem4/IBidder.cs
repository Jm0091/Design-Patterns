using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    /// <summary>
    /// This is an interface the all bidders must implement.
    /// this interface is the observer Interface of oberserv pattern. 
    /// </summary>
    public interface IBidder
    {

        public string getName();
        public double getMaximumLimit();
        public void Notify(string announcment);
        
    }
}
