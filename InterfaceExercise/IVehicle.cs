using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Model { get; set; }
        public bool Seats { get; set; } 
        public bool HasCupHolders { get; set; }
        public bool HasGasPedal { get; set; } 

        public void DisplayDetails()
        {
            Console.WriteLine("Driving implementation");
        }
      
    }
}
