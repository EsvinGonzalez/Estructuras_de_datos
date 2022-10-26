using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Altura_Personas
    {
        private float[] alturas;
        private float promedio;

        public void Cargar() 
        {
            alturas=new float[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese la altura de la persona:  ");
                string linea = Console.ReadLine();
                alturas[f] = float.Parse(linea);
            }
        }
    
        public void CalcularPromedio() 
        {
            float suma;
            suma=0;
            for(int f=0; f < 5; f++) 
            {
                suma=suma+alturas[f];
            }
            promedio=suma/5;
            Console.WriteLine("Promedio de altura: "+promedio);
        }

        public void MayoresMenores() 
        {
            int may,men;
            may=0;
            men=0;
            for(int f = 0; f < 5; f++) 
            {
                if (alturas[f] > promedio) 
                {
	                may++;
                }
                else
                {
                    if (alturas[f] < promedio) 
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Personas mayores al promedio:  "+may);
            Console.WriteLine("Personas menores al promedio:  "+men);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Altura_Personas pv2 = new Altura_Personas();
            pv2.Cargar();
            pv2.CalcularPromedio();
            pv2.MayoresMenores();
        }
    }
}                       