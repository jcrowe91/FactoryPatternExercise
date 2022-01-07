using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    class VehicleFactory
    {
        public static IVehicle GetVehicle(string userInput)
        {
            switch (userInput)
            {
                case "2":
                    return new Motorcycle();                 
                case "4":
                    return new Truck();
                default:
                    return new Motorcycle();
            }
        }
    }
    
}

