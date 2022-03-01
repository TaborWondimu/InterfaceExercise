using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise 
{
public  class Car :IVehicle, ICompany
    {
        public Car()
        {

        }
        public bool HasTrunk { get; set; }

        public string Cut { get; set; }
        public int numOfTires { get; set; }
          
         
        public string Color { get; set;}
        public string Make { get; set;}
        public int Year { get; set; }
        public string Name { get; set; }
        public string Country { get; set;}

        public  void TimeOfPurchase()
        {
            Console.WriteLine($"Time Purchased Is {DateTime.Now}");
        }
    }
}
