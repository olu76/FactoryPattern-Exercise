using System;

namespace FactoryPatternExercise_Console
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("How many tires will your vehicle have?");
            string numberOfWheels = Console.ReadLine();

             IVehicle vehicle1 = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle1.Drive();
        }
    }
}
