using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels would you like on the vehicle?");
            string userImput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
            IVehicle userVehicle = VehicleFactory.GetVehicle(userImput);

            userVehicle.Drive();

        }
    }
}
