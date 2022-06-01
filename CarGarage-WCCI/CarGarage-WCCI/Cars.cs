using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage_WCCI
{
    public class Cars : Vehicle
    {
        // object characteristics - properties
        // accessModifier varType varName = syntax
        public string Make;
        public string Model;
        public int MPG;
        public double FuelLevel; // gallons of fuel remaining

        // class's constructor - Constructs an instance of our class.
        // we use a constructor to make an object
        // accessModifier className(parameter/inputs) {code we write} - syntax
       public Cars()
        {
            Make = "Chrysler";
            Model = "PT Cruiser";
            MPG = 19;
            FuelLevel = 100;
            Speed = 0;
            TopSpeed = 80;
        }

        public Cars(string make, string model, int mpg, int fuelLevel, int speed, int topspeed)
        {
            Make = make;
            Model = model;
            MPG = mpg;
            FuelLevel = fuelLevel;
            Speed = speed;
            TopSpeed = topspeed;
        }

        //object's functionally - methods
        // the actions an object can take
        // accessModifier  optionalmodifier returnType name(inputs) {code}
        public override void Accelerate()
        {
            if(Speed <= TopSpeed)
            {
                Speed += 5;
            }
        }
        public override void Brake()
        {
            if(Speed >= 5)
            {
                Speed -= 5;
            }
        }
        // what do we want to update every frames/timestep?
        public override void Tick()
        {
            if(Speed > 0)
            {
                Speed--;
            }
            if(FuelLevel > 0)
            {
                FuelLevel -= ((Speed / 60) / (float)MPG); // type casting
            }
            if(Speed < 0)
            {
                Speed = 0;
            }
            if(Speed < 0)
            {
                FuelLevel = 0;
            }
        }

        public void ReFuel()
        {
            FuelLevel = 100;
        }
    }
}
