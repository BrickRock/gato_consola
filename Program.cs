using System;
using System.Collections.Generic;

namespace programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            tablero tabla = new tablero();
            int number = 5;
            do{
                Console.Clear();
                tabla.dibujar();
                tabla.Matriz();
                number--;
                Console.ReadKey();
            }while(number > 0);
        }
    }
}
