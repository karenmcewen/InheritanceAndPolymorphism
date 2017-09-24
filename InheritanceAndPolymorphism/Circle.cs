using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Circle : IShape //inherits from the interface IShape
    {
        //FIELDS - only need those that are specific to this class
        //number of circles -  - static means only one instance of this variable
        public static int circleNumber; 
        
        //PROPERTIES
        public int CircleNumber
        {
            get { return this.CircleNumber; }
        }
        
            
        public string Name { get; set; }
        public double Radius { get; set; }
        
        //CONSTRUCTOR
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
            circleNumber += 1; //number increases with each new instance of Circle created
        }

        //METHODS
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
