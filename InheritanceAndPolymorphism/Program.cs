using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of Class Boat
            Boat ssJordan = new Boat(2, 500, "red", 80.0d, 0.90d);
            ssJordan.Move();
            ssJordan.Move();
            Console.WriteLine("Boat "+ssJordan.GetDistanceTraveled());

            //creating an instance of Class Car
            Car tesla = new Car(4, 22f, 2, 2, 500, "yellow", 250d);
            tesla.Move();
            tesla.Move();
            Console.WriteLine("Car "+tesla.GetDistanceTraveled());
        }
    }
}
