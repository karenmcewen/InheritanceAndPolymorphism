using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Boat:Vehicle //creates class Boat as a derived class of Vehicle
    {
        private double waterDrag; //don't need a property for this because not using outside of this class??
        
        //CONSTRUCTOR
        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        //METHODS - need to override the method from the parent class because the boat moves differently

        public override void Move() //we can only override this because of the 'virtual' keyword in vehicle
        {
            distanceTraveled += movementSpeed * waterDrag;
        }
        
            
    }
    }
