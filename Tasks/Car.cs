using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
     public abstract class Car : IVehicle
    {
        
        public string Model { get; set; }

        public int Fuel { get; set; }

        public Car(string model, int fuel)
        {
            this.Model = model;
            this.Fuel = fuel;
        }

        public void Drive()
        {
           if(Fuel > 0)
            {
                Console.WriteLine("We are driving");
            } else
            {
                Console.WriteLine("You cant drive with no fuel");
            }
        }
        public void Refuel(int howMuchRefuel)
        {
            if(howMuchRefuel > 0)
            {
                Fuel += howMuchRefuel;
            }
            
        }

    }
}
