using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rettangolo
    {
        private double altezza;
        private double larghezza;

        public double Altezza
        {
            get { return altezza; }
            set
            {
                if (value > 0)
                {
                    altezza = value;
                }
                else
                {
                    altezza = 1;
                }
            }       
        }
        public double Larghezza
        {
            get { return larghezza; }
            set
            {
                if (value > 0)
                {
                    larghezza = value;
                }
                else
                {
                    larghezza = 1;
                }
            }
        }       

        public static int ConteggioRettangoli { get; set; }


        /*public Rettangolo(double altezza = 1, double larghezza = 1) // all in one
        {
            Altezza = altezza;
            Larghezza = larghezza;
            ConteggioRettangoli ++;
        }  */      
        public Rettangolo( double altezza , double larghezza)
        {
            Altezza = altezza;
            Larghezza = larghezza;
            ConteggioRettangoli++;
        }

        public Rettangolo() : this(1, 1)
        {
            
        }
     
        public double CalcoloArea()
        {                     
            return this.Altezza * this.Larghezza;
        }

        public double CalcoloArea(int n)
        {
            return this.Altezza * this.Larghezza * n;
        }

        public static Rettangolo ConfrontaAree(Rettangolo r1, Rettangolo r2)
        {
            if (r1.CalcoloArea() < r2.CalcoloArea())
            {
                return r2;
            }
            else
            {
                return r1;
            }
        }
    }
}
