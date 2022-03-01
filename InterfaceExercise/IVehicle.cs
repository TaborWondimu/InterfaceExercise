using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
  public interface IVehicle
    {
        public int numOfTires { get; set; }
        public string Color { get; set; } // stubbed out methods
        public string Make { get; set; }
        public int Year { get; set; }

        public void TimeOfPurchase();
       
    }
   
    
}
