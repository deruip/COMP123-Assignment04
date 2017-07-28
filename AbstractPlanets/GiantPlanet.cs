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
    /// <summary>
    /// GiantPlanet class that extends Planet parent class
    /// Implements IHasMoons and IHasRings interfaces
    /// </summary>
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //private instance variables
        private string _type;

        //constructors
        /// <summary>
        /// Main constructor for GiantPlanet class
        /// Takes four arguments: name (string) - diameter (double) - mass (double) - type (string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
        {
            this._type = type;
        }

        //public methods
        /// <summary>
        /// Returns true if there is at least one moon
        /// </summary>
        public bool HasMoons()
        {
            return (this.MoonCount > 0);
        }
        /// <summary>
        /// Returns true if there is at least one ring
        /// </summary>
        public bool HasRings()
        {
            return (this.RingCount > 0);
        }
    }
}