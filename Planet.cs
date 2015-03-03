using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment_3
{
    public class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double rotationPeriod;


       //read only
        public double Diameter
        {
            get
            {
                return _diameter;
            }
           
        }

        //read only
        public double Mass
        {
            get
            {
                return _mass;

            }
       
        }

        public int MoonCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //read only
        public string Name
        {
            get
            {
                return _name;
            }
          
        }

        public double OrbitalPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int RingCount
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public double RotationPeriod
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Planet(string name, double diameter, double mass)
        {
                    
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }


      override public void ToString()
        {
            Console.WriteLine("Name: {0}\n Diameter: {1}\n Mass: {2}", Name, Diameter, Mass);
        }
    
    }
}
