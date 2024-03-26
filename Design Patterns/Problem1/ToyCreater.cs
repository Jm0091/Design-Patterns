using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    ///    ToyCreater Class used for create object of any Toy. uses switch statement and throws exception for invalid type (Factory Creater)
    /// 
    /// I Jems Chaudhary certify that it is my original work. No other person's work has been used without due acknowledgement.
    /// </summary>

    public class ToyCreater
    {
        public IToy GetToy(string type)
        {
            switch (type)
            {
                case "Car":
                    return new Car();
                case "DancingCactus":
                    return new DancingCactus();
                case "Dollhouse":
                    return new Dollhouse();
                case "RainbowStacker":
                    return new RainbowStacker();
                case "StuffedAnimal":
                    return new StuffedAnimal();
                default:
                    throw new NotSupportedException();
            }

        }
    }
}
