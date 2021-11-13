using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise_Console
{
    public class Suv : IVehicle
    {
        public Suv()
        {
        }

      
          
        

        public void Drive()
        {
            Console.WriteLine("The Suv is driving at safe pace");
        }
    }
}
