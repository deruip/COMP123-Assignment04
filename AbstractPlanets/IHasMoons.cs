using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Aron Ly
 * Student #: 300932437
 * Date: July 27, 2017
 * Description: IHasMoons interface
 * Version: 0.1 - Interface created
 */
namespace AbstractPlanets
{
    public interface IHasMoons
    {
        /// <summary>
        /// Returns true if planet has at least one moon
        /// </summary>
        bool HasMoons();
    }
}