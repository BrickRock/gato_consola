using System;
using System.Collections.Generic;

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
            ia.coProhibida.Add(new coordenada(fila, columna));
            
        }
    }

    public static class ia
    {
        public static List<coordenada> Todas = new List<coordenada>();
        public static List<coordenada> coProhibida = new List<coordenada>();
        private static List<coordenada> coPermitidas = new List<coordenada>();
        
        public static void filtra()
        {
            
        }
        


    }

    public class coordenada
    {
        int fila,columna;
        public coordenada(int fila, int columna)
        {
            (this.fila, this.columna) = (fila,columna);
        }

        public void obtenerCordenada(out int filap, out int columnap)
        {
            filap= fila;
            columnap= columna;
        }
    }
}