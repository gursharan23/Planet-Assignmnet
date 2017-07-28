using System;
using System.Collections.Generic;
/*
 * Name : Gursharan Singh
 * Student Number : 300931676
 * Date : 23 July, 2017
 * Description : This is the main driver class
 * Version: 0.4 Tested all the methods of GiantPlanet and TerrestrialPlanet class
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
            //Checking giant planet
            Console.WriteLine("Planet\t\tDiameter  \tMass");
            Console.WriteLine("=====================================\n");
            Console.WriteLine("Giant Planet");
            Console.WriteLine("================");
            GiantPlanet giantPlanet=new GiantPlanet("Jupiter",1.3*Math.Pow(10,5),1.898*Math.Pow(10,27),"Gas");
            Console.WriteLine(giantPlanet.ToString());
            Console.WriteLine("\nIs this planet have moons ");
            Console.WriteLine("=============================\n");
            giantPlanet.MoonCount = 69;  //Setting the value for MoonCount
            Console.WriteLine(giantPlanet.HasMoons().ToString()); //Checking the MoonCount
            Console.WriteLine("This planet has : "+giantPlanet.MoonCount+" moon(s)\n");
            Console.WriteLine("Is this planet have rings ");
            Console.WriteLine("=============================\n");
            giantPlanet.RingCount = 0; //Setting the value for RingCount
            Console.WriteLine(giantPlanet.HasRings().ToString()); //Checking the RingCount
            Console.WriteLine("This planet has : "+giantPlanet.RingCount+" ring(s)");
            //Checking terrestrial planet
            Console.WriteLine("\nTerrestrial Planet");
            Console.WriteLine("===================");
            TerrestrialPlanet terrestrialPlanet=new TerrestrialPlanet("Earth",1.2*Math.Pow(10,4),5.972*Math.Pow(10,24),true);
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.WriteLine("\nIs this planet have moons ");
            Console.WriteLine("=============================\n");
            terrestrialPlanet.MoonCount = 1; //Setting the value for MoonCount
            Console.WriteLine(terrestrialPlanet.HasMoons().ToString()); //Checking the MoonCount
            Console.WriteLine("This planet has : "+terrestrialPlanet.MoonCount+" moon(s)\n");
            Console.WriteLine("Is this planet is Habitable");
            Console.WriteLine("===========================");
            Console.WriteLine(terrestrialPlanet.Habitable().ToString()); //Checking the planet for its habituality
            WaitForAnyKey();
        }
        //Private Methods
        /// <summary>
        /// This is a private method with no parameters 
        /// This method is used to close the cancel
        /// </summary>
        private static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}