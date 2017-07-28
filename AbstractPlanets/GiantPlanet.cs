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
 * Version: 0.3 - Implemented IHasMoons and IHasRings interfaces
 * Version: 0.4 - Cleaned up return logic on methods
 */
namespace AbstractPlanets
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //private instance variables
        private string _type;

        //constructors
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        //public methods
        public bool HasMoons()
        {
            return (this.MoonCount > 0);
        }
        public bool HasRings()
        {
            return (this.RingCount > 0);
        }
    }
}