using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Student #: 300932437
 * Date: July 27, 2017
 * Description: GiantPlanet class that extends Planet parent class
 * Version: 0.1 - Class created
 * Version: 0.2 - Implemented private instance variables, constructor, and HasMoons/HasRings methods
 */
namespace AbstractPlanets
{
    public class GiantPlanet : Planet
    {
        //private instance variables
        private string _type;

        //public properties

        //constructors
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }
        //private methods

        //public methods
        public bool HasMoons()
        {
            if (this.MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasRings()
        {
            if (this.RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}