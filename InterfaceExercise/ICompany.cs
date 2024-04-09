using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public bool Logo { get; set; }
        public bool MissionStatement { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine("Company implementation");
        }
    }
}
