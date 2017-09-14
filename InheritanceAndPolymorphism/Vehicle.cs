using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Vehicle //This is our new BASE CLASS
    {
        //FIELDS
        //protected fields - can be accessed by parent and derived classes
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        //private fields - can only be accessed by this class
        private float gearRatio;
        private float engineSize;

        //PROPERTIES
        public int Seats
        {
            get { return this.seats; }
        }
        
        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; } //set allows this property to be changed
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        //CONSTRUCTORS

        public Vehicle()
        {

        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0.0d;
        }

        //METHODS -derived classes can override methods from the parent class using "virtual" keyword
        public virtual void Move()
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled: " + distanceTraveled + "\n";

        }

        ///////////////////////
    }
}
