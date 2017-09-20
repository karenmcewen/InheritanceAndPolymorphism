using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{


    //example of an abstract class - can only be inherited (non-complete class)
    abstract class Shape
    {
        //PROPERTY (Property created in background?)
        public string Name { get; set; } //using this shorthand, the property created in the background
             
        
        //CONSTRUCTORS - not necessary to have a default constructor use in abstract classes 
        //these are required for concrete classes or else the child classes will give an error
        public Shape (string name) //uppercase Shape is property, lowercase name is value passed into it
        {
            Name = name;
        }
        //METHODS
        abstract public double Area(); //this has an empty body because it is marked abstract

        public void GetInfo() //here we can create a body, even though it is an abstract class
        {
            Console.WriteLine("I am a {0}",Name); //will print name of the shape
        }
    }
}
