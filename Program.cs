using System;
using System.Collections;
using System.Collections.Generic;

namespace programa01
{
    class Program
    {
        public static bool jugadas = true;
        static void Main(string[] args)
        {
            int desicion = 0;
        do{
            tablero tabla = new tablero();

            while(jugadas){
                Console.Clear();
                tabla.dibujar();// rellena el array y lo imprime en forma de tablero
                
                Console.ReadKey();
                    }

            Console.WriteLine("El juego acabo desea volverlo a ejecutar? ingrese si=1 / no=2");
            try{
                desicion = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException){
                Console.WriteLine("Por favor ingrese un numero");
            }
            
            }while(desicion == 1);
        }
    }   
}
