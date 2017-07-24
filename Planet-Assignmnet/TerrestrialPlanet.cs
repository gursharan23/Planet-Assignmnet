/*
 * Name : Gursharan Singh
 * Date : 24 July, 2017
 * Description : This is the sub class of abstract class
 * Version: 0.2 Added HasMoons and Habitable methods to implement the interfaces
 */
namespace Planet_Assignmnet
{
    /// <summary>
    /// This is the sub class called Terrestrial Planet
    /// </summary>
    public class TerrestrialPlanet:Planet,IHasMoons,IHabitable
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
        //Public methods
        /// <summary>
        /// This is the HasMoons method which has no parameters
        /// It checks whether the moon count is greater than zero or not.
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            if (MoonCount>0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// This is the Habitable method which has no parameters
        /// It checks whether the instance variable oxygen is set to true .
        /// </summary>
        /// <returns></returns>
        public bool Habitable()
        {
            if (this._oxygen)
            {
                return true;
            }
            return false;
        }

    }
}