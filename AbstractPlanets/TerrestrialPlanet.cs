using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Student #: 300932437
 * Date: July 27, 2017
 * Description: TerrestrialPlanet class that extends Planet parent class
 * Version: 0.1 - Class created
 * Version: 0.2 - Implemented private instance variables, constructor, and HasMoons and Habitable methods
 * Version: 0.3 - Implemented IHasMoons and IHabitable interfaces
 */
namespace AbstractPlanets
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //private instance variables
        private bool _oxygen;

        //constructors
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        //public methods
        public bool HasMoons()
        {
            return (this.MoonCount > 0);
        }
        public bool Habitable()
        {
            return (this._oxygen);
        }
    }
}