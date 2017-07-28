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
 * Version: 0.2 - Added
 */
namespace AbstractPlanets
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Feros", 16732, 1.879, "Ice");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Noveria", 11312, 0.63, true);
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();
        }
        public static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
