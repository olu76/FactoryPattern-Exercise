using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise_Console
{
    public static class VehicleFactory
    {

        public static IVehicle GetVehicle(string wheel)
        {

            switch (wheel.ToLower())
            {
                case "4":
                    return new Car();
                case "2":
                    return new Suv();
                default:
                    return new Car();
            }
        }
    }
}
       