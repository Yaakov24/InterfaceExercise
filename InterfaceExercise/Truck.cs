using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string Model { get; set; } = "Mack";
        public bool IsLoud { get; set; } = true;
        public bool Wheels { get; set; } = true;
        public bool Seats { get; set; } = true;
        public bool HasCupHolders { get; set; } = true;
        public bool HasGasPedal { get; set; } = true;
        public bool Logo { get; set; } = true;
        public bool MissionStatement { get; set; } = true;
        public void DisplayDetails()
        { 
            Console.WriteLine("Truck implementation");
        }
    }
}
