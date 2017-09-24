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
        //PROPERTY (private fields are automatically created in background when the property is created)
        public string Name { get; set; } //using this shorthand, the property created in the background
             
        
        //CONSTRUCTORS for ABSTRACT CLASS- not necessary to have a default constructor use in abstract classes 
        //these are required for concrete classes or else the child classes will give an error
        public Shape (string name) //uppercase Shape is property, lowercase name is value passed into it
        {
            Name = name;
        }
        //ABSTRACT METHODS
        //abstract methods have NO {BODY} 
        //abstract methods MUST be fulfilled in the inheriting classes,
        //which is one reason to use 'abstract' - so that you do not forget to implement them in the child classes
        abstract public double Area();

        //regular METHOD in an abstract class
        //here we can create a body, even though it is an abstract class
        public void GetInfo() 
        {
            Console.WriteLine("I am a {0}",Name); //will print name of the shape
        }
    }
}
