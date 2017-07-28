using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aron Ly
 * Student #: 300932437
 * Date: July 27, 2017
 * Description: Driver class
 * Version: 0.1 - Class created
 * Version: 0.2 - Added test harness
 */
namespace AbstractPlanets
{
    /// <summary>
    /// Driver class with test harness
    /// Creates giantPlanet object and calls its ToString() method
    /// Creates terrestrialPlanet object and calls its ToString() method
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //GiantPlanet testing
            GiantPlanet giantPlanet = new GiantPlanet("Feros", 16732, 1.879, "Ice");
            Console.WriteLine(giantPlanet.ToString());
            //TerrestrialPlanet testing
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Noveria", 11312, 0.63, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();
        }
        /// <summary>
        /// Waits for a key press before closing the console
        /// </summary>
        public static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
