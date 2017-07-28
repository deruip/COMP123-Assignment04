using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Aron Ly
 * Student #: 300932437
 * Date: July 27, 2017
 * Description: Abstract Planet superclass
 * Version: 0.1 - Class created
 * Version: 0.2 - Implemented private instance variables, public properties, constructor and overrided ToString method
 * Version: 0.3 - Added units for ToString() method
 */
namespace AbstractPlanets
{
    /// <summary>
    /// Abstract Planet superclass that GiantPlanet and TerrestrialPlanet derives from
    /// </summary>
    public abstract class Planet
    {
        //private instance variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //public properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //constructors
        /// <summary>
        /// Main constructor for Planet superclass
        /// Takes three arguments: name (string) - diameter (double) - mass (double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //public methods
        /// <summary>
        /// Overrides the built-in ToString() function to display desired output
        /// </summary>
        public override string ToString()
        {
            return string.Format("Name: {0}\nDiameter: {1} km - Mass: {2} Earth Masses", Name, Diameter, Mass);
        }

    }
}