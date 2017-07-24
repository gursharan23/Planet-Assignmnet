/*
 * Name : Gursharan Singh
 * Date : 24 July, 2017
 * Description : This is the sub class of abstract class
 * Version: 0.1 Created Terrestrial Planet Class
 */
namespace Planet_Assignmnet
{
    /// <summary>
    /// This is the sub class called Terrestrial Planet
    /// </summary>
    public class TerrestrialPlanet:Planet
    {
        //Private Instance Variables
        private bool _oxygen;
        
        //Constructor
        /// <summary>
        /// This is the main constructor which takes all the parameters of its subclass
        /// along with its own one parameter - oxygen(bool)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        
    
        
    }
}