using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car()
            {   Model = "Toyota",
                IsShort = true,
                Wheels  = true,
                Seats = true,
                HasCupHolders = true,
                HasGasPedal  = true,
                Logo = true,
                MissionStatement = true,
            };
            SUV suv = new SUV()
            {
               Model = "Suburban",
               Has8Seatbelts = true,
               Wheels = true,
               Seats  = true,
               HasCupHolders = true,
               HasGasPedal = true,
               Logo = true,
               MissionStatement = true,
            };
            Truck truck = new Truck()
            {
                Model = "Mack",
                IsLoud  = true,
                Seats  = true,
                HasCupHolders = true,
                HasGasPedal  = true,
                Logo  = true,
                MissionStatement  = true,
            };

            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(car);
            vehicles.Add(suv);
            vehicles.Add(truck);

            foreach(var item in vehicles)
            {   Console.WriteLine($"Vehical Model:{item.Model}");
                Console.WriteLine($"GasPetal:{item.HasGasPedal}");
                Console.WriteLine($"Cup Holders:{item.HasCupHolders}");
                Console.WriteLine($"Seats:{item.Seats}");
                Console.WriteLine();
            }
                
            
            
            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
