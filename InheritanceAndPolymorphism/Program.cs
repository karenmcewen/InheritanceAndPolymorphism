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
            ////creating an instance of Class Boat
            //Boat ssJordan = new Boat(2, 500, "red", 80.0d, 0.90d);
            //ssJordan.Move();
            //ssJordan.Move();
            //Console.WriteLine("Boat "+ssJordan.GetDistanceTraveled());

            ////creating an instance of Class Car
            //Car tesla = new Car(4, 22f, 2, 2, 500, "yellow", 250d);
            //tesla.Move();
            //tesla.Move();
            //Console.WriteLine("Car "+tesla.GetDistanceTraveled());


            //SHAPES BASE CLASS EXAMPLE
            Square square1 = new Square("square", 5);
            square1.GetInfo();
            Console.WriteLine(square1.Area());

            //IShapes example
            Circle circle1 = new Circle("circle", 10);
            circle1.GetInfo();
            Console.WriteLine(circle1.Area());
            Console.WriteLine(circle1.CircleNumber);

            Circle circle2 = new Circle("circle", 12);
            circle2.GetInfo();
            Console.WriteLine(circle2.Area());
            Console.WriteLine(circle2.CircleNumber);

        }
    }
}
