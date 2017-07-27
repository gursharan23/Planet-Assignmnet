using System;
using System.Collections.Generic;
/*
 * Name : Gursharan Singh
 * Student Number : 300931676
 * Date : 23 July, 2017
 * Description : This is the main driver class
 * Version: 0.2 Added WaitForAnyKey method
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
            GiantPlanet planet=new GiantPlanet("Jupiter",100.25,150,"Ice");
            Console.WriteLine(planet.ToString());
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