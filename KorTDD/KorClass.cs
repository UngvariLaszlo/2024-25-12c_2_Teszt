﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorTDD
{
    public class KorClass
    {
        //Osztályváltozó
        public double sugar = 0.0,
            kerulet = 0.0,
            terulet = 0.0;

        //Konstruktor
        public KorClass(double r)
        {
            this.sugar = r;
        }
        public void setSugar(double r) { this.sugar = r; }
        //Kerület számytás
        public double SetKerulet(double r)
        { 
            if (r <= 0)
            {
                throw new ArgumentException();
            }
            return 2*this.sugar*Math.Round(Math.PI,2);

        }
        //Terület számítás
        public double SetTerulet(double r)
        { 
            return r*r*Math.Round(Math.PI, 2);
        }
        public double getSugar() 
        { 
            return sugar; 
        }
    }
}
