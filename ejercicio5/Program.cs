using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Matriz_4x4
    {
        private int[,] mat;

        public void cargar() 
        {
            mat=new int[4,4];
            for(int f = 0; f < 4; f++) 
            {
                for(int c = 0; c<4; c++) 
                {
                    Console.Write("Ingrese posicion  ["+(f+1)+","+(c+1)+"]: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }
       
            
        public void ImprimirDiagonalPrincipal() 
        {
            for(int k = 0; k < 4; k++) 
            {
                Console.Write(mat[k,k]+" ");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz_4x4 ma = new Matriz_4x4();
            ma.cargar();
            ma.ImprimirDiagonalPrincipal();
        }
    }
}