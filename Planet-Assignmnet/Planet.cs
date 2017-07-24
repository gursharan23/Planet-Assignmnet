using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name : Gursharan Singh
 * Date : 23 July, 2017
 * Description : This is the abstract planet class
 * Version: 0.1 Created  planet class
 */
namespace Planet_Assignmnet
{
    /// <summary>
    /// This is the abstract planet class
    /// </summary>
    public abstract class Planet
    {
        // Private instance variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        // Public properties
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
            get { return this._name; }
            
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
        // Constructors
        /// <summary>
        /// This is the main constructor with three arguments - name(string), diameter(double), mass(double)
        /// </summary>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass; 
        }
        public override string ToString()
        {
            return string.Format("{0,10}{1:d,5},{2:d,5}",Name,Diameter,Mass);
        }
        // Public Methods

    }
}