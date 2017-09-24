using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    interface IShape
    {
        //you can have as many interfaces as you want
        //INTERFACES name convention - begin with "I"

        //METHODS
        void GetInfo(); //interface methods cannot have a body {}
        double Area();
        
    }
}
