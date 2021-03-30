using System;
using System.Collections;
using System.Collections.Generic;

namespace programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            tablero tabla = new tablero();
            int f = 0,c = 0;
            int number = 3;
            do{
                Console.Clear();
                tabla.dibujar();
                tabla.Matriz();
                number--;
                Console.ReadKey();
            }while(number > 0);
            

            foreach(coordenada cood in ia.Todas)
            {
                cood.obtenerCordenada(out f , out c);
                Console.WriteLine("la f es {0} , y la c es{1}",f,c);
            }
            
        }
    }   
}
