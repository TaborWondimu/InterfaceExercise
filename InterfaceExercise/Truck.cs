using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
  public  class Truck : IVehicle, ICompany
    {
        public Truck()
        {
            // constructor
        }

        public bool HasBed { get; set; }
        public bool IsManual { get; set; }
        public int numOfTires { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public void TimeOfPurchase()
        {
            Console.WriteLine($"Time Purchased Is {DateTime.Now}");
        }
    }
}

