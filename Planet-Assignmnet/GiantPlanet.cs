/*
 * Name : Gursharan Singh
 * Date : 23 July, 2017
 * Description : This is the sub class of abstract class
 * Version: 0.2 Added HasMoons Method
 */
namespace Planet_Assignmnet
{
    /// <summary>
    /// This is the sub class called Giant Planet
    /// </summary>
    public class GiantPlanet:Planet,IHasMoons
    {
        //Private instance variables
        private string _type;
        //Constructor
        /// <summary>
        /// This is the main constructor which has all the parameters of its superclass 
        /// with one of its own also - type(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass,string type) : base(name, diameter, mass)
        {
            this._type = type;
        }
        //Private Methods
        //Public Methods
        /// <summary>
        /// This is the HasMoons mrhod which has no parameters
        /// It checks whether the moon count is greater than zero or not
        /// </summary>
         public bool HasMoons()
        {
            if (MoonCount>0)
            {
                return true;
            }
            return false;
        }
    }
}