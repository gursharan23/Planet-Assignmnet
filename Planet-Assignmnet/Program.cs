using System;
using System.Collections.Generic;
/*
 * Name : Gursharan Singh
 * Student Number : 300931676
 * Date : 23 July, 2017
 * Description : This is the main driver class
 * Version: 0.3 Refactored program class
 */
namespace Planet_Assignmnet
{
    /// <summary>
    /// This is the driver class
    /// </summary>
   internal class Program
    {
        public static void Main(string[] args)
        {
            GiantPlanet planet=new GiantPlanet("Jupiter",1.3*Math.Pow(10,5),1.898*Math.Pow(10,27),"Gas");
            TerrestrialPlanet terrestrialPlanet=new TerrestrialPlanet("Earth",1.2*Math.Pow(10,4),5.972*Math.Pow(10,24),true);
            Console.WriteLine(planet.ToString());
            Console.WriteLine(terrestrialPlanet.ToString());
            WaitForAnyKey();

        }
        //Private Methods
        /// <summary>
        /// This is a private method with no parameters 
        /// This method is used to close the cancel
        /// </summary>
        private static void WaitForAnyKey()
        {
            Console.WriteLine("  Press any key to exit");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}