using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rettangolo
    {
        public double Altezza { get; set; }
        public double Larghezza { get; set; }

        public static int ConteggioRettangoli {get; set;}


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
