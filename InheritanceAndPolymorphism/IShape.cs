using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    interface IShape
    {
        

        //METHODS
        void GetInfo(); //interface methods cannot have a body {}
        double Area();
        
    }
}
