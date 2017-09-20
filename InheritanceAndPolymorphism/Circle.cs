using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Circle : IShape
    {
        //field
        public static int circleNumber; //number of circles - this is a field only in this class - static means only one instance of this variable
        
        //properties
        public int CircleNumber
        {
            get { return this.CircleNumber; }
        }
        
            
        public string Name { get; set; }
        public double Radius { get; set; }
        
        //constructor
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
            circleNumber += 1;
        }
        public double Area()
        {
            double pi = Math.PI; //MATH is a special system class we have access to
            return pi * Math.Pow(Radius, 2); //power
        }

        public void GetInfo()
        {
            Console.WriteLine("I am a " +Name);
        }

        public void NumberOfCircles()
        {
            
            Console.WriteLine("The number of circles is " +circleNumber);
        }
    }
}
