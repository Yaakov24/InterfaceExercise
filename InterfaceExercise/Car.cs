using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string Model { get; set; } = "Toyota";
        public bool IsShort { get; set; } = true;
        public bool Wheels { get; set; } = true;
        public bool Seats { get; set; } = true;
        public bool HasCupHolders { get; set; } = true;
        public bool HasGasPedal { get; set; } = true;
        public bool Logo { get; set; } = true;
        public bool MissionStatement { get; set; } = true;

        public void DisplayDetails()
        {
            Console.WriteLine("Car details implementation");
        }

    }
}
