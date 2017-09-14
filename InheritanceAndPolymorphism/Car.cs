using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Car:Vehicle
    {
        //FIELDS
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        //PROPERTIES
        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }
        
        //CONSTRUCTOR
        public Car(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }
        //METHODS - can use the methods already developed in parent class Vehicle - don't need to override
    }
}
