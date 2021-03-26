using System;

namespace programa01
{
    public static class jugador
    {
        private static char x = 'x';
        private static int columna;
        private static int fila;

        public static int Columna{ get{return columna;}}

        public static char turno { get => x;}

        public static int Fila {get => fila;}

        public static void imput()
        {
            Console.WriteLine("Selecciona la fila: ");
            fila = Convert.ToInt32(Console.ReadLine());
            fila -= 1;

            Console.WriteLine("Selecciona la columna: ");
            columna = Convert.ToInt32(Console.ReadLine());
            columna -= 1;

            
        }
    }

    public class ia
    {
        char y = 'y';
        
    }
}