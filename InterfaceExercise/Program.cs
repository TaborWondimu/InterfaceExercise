using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* DONE Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*DONE Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*DONE Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            Car car = new Car() { Name = " HONDA", Cut = "Sedan", numOfTires = 4, HasTrunk = true, Color = "Blue", Country ="Japan", Year = 2015,Make = "Accord"};
            SUV suv = new SUV() { Name = " FORD", SUVExterior = "Blue", numOfTires = 6, HasCargo = true, Color = "Red", Country = "USA", Year = 2055, Make = "F-150" };
            Truck truck = new Truck() { Name = " VOLVO",IsManual = true, numOfTires = 18, HasBed = true, Color = "White", Country = "Germany", Year = 2010, Make = "BigT" };
            
            var vehicles = new List<IVehicle>() { car,truck,suv};
            vehicles.Add(car);
            vehicles.Add(suv);  
            vehicles.Add(truck);

            foreach (var items in vehicles)
            {
                Console.WriteLine($"---------------------------");
                Console.WriteLine($"Tires {items.numOfTires},Make {items.Make}, Color {items.Color}, Year {items.Year}");
               
                items.TimeOfPurchase();
               
            }
            
        }
    }
}
