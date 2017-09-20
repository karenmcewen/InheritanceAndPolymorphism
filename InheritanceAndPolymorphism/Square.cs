﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Square:Shape
    {
        //class that inherits from the abstract class MUST implement all of the abstract members

        public double Length{ get; set; }

        public Square(string name, double length):base(name) //constructor - MUST use the base keyword (?)
        {
            Length = length;
        }

        public override double Area() //MUST override method from the abstract parent class
        {
            return Length * Length;
        }
    }
    
}
