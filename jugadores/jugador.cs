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
            bool error = true, excepcion = false;
            do{
                try{

                    if(error== false && excepcion) Console.WriteLine("Ese cordenada no es valida"); 
                    excepcion = false;
                    Console.WriteLine("Selecciona la fila: ");
                    fila = Convert.ToInt32(Console.ReadLine());
                    fila -= 1;

                    Console.WriteLine("Selecciona la columna: ");
                    columna = Convert.ToInt32(Console.ReadLine());
                    columna -= 1;
                    
                    error = CoordeanadaProhibida(fila, columna);
                    excepcion = !error;
                    ia.coProhibida.Add(new coordenada(fila, columna));
                } catch (FormatException)
                {
                    System.Console.WriteLine("porfavor ingrese valores numericos validos");
                    excepcion = false;
                    error = false;
                    
                }
            }while(!error);
            
        }

        private static bool CoordeanadaProhibida(int fila, int columna)
        {
            bool chequeo = true;
            foreach(coordenada Prohibida in ia.coProhibida){
                chequeo = (fila, columna) != (Prohibida.Fila, Prohibida.Columna);
                if(chequeo == false) break;
            }
            System.Console.WriteLine(chequeo);
            return chequeo;
        }
    }

    public static class ia
    {
        public static char turno{ get => 'o';}
        public static List<coordenada> Todas = new List<coordenada>();
        public static List<coordenada> coProhibida = new List<coordenada>();
        private static List<coordenada> coPermitidas = new List<coordenada>();
        
        private static Predicate<coordenada> predicado = filtraNumeros;
        public static void filtra()
        {
            coPermitidas = Todas.FindAll(predicado);
           
        }

        public static coordenada jugada()
        {
            filtra();
            int numRandom;      
            var rand = new Random();
            numRandom = rand.Next(coPermitidas.Count);
            coProhibida.Add(coPermitidas[numRandom]);
            return coPermitidas[numRandom];
        }

        private static bool filtraNumeros(coordenada obj)
        {
            bool contiene=false;
            foreach(coordenada coord in coProhibida)
            {
                
                contiene = (obj.Fila, obj.Columna) != (coord.Fila, coord.Columna);
                if(contiene == false) break;
            }
            return contiene;
        }
        


    }

    public class coordenada
    {
        private int fila,columna;
        public int Fila {get => fila;}
        public int Columna {get => columna;}

        public coordenada(int fila, int columna)
        {
            (this.fila, this.columna) = (fila,columna);
        }

        public void obtenerCordenada(out int filap, out int columnap)
        {
            filap= fila;
            columnap= columna;
        }

        public override string ToString()
        {
            return fila + " " + columna;
        }  
    }
}