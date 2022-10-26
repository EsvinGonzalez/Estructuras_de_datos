using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Operario
    {
        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[5];
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Ingrese el sueldo:  ");     
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }
    
        public void Imprimir() 
        {
            for(int f = 0; f < 5; f++) 
            {
                Console.Write("Sueldo del Operario   =  Q." );
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Operario pv = new Operario();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}