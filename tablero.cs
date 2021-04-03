using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace programa01
{
    public class tablero 
    {
        public char[,] matriz = new char[3,3];
        Validacion validador;
        int i = 1;
        
        char turno;
        int unico = -1;
        
        public void Matriz()  // imprime el array en forma de matriz
        {
            for(int i= 0; i<3;i++)
            {
                for(int j= 0; j<3;j++)
                {
                    
                    Console.Write(" | ");
                    Console.Write(matriz[i,j]);
                    if(j==2) Console.Write(" |");
                        
                }

                Console.WriteLine("\n ______________\n");
            }
        }

        public void OnlyOne()
        {
            validador = new Validacion(matriz);
            validador.DefinirCombinaciones();
        }
        public void dibujar() //pide al jugador ingresar los datos y los guarda en el array 
        {
            coordenada iaCoordenada;
            
            if(i==1) OnlyOne(); // solo llamar una vez "enseña" a la maquina cuales son las combinaciones ganadoras
            i++;
            if(Program.jugadas)
            {
                SinCasillas();
                rellenar();
                Matriz();
                jugador.imput();
                matriz[jugador.Fila, jugador.Columna] = jugador.turno; // en la posicion que elegio el jugador asigno la x
                
            
                if(validador.Verificar(jugador.Fila, jugador.Columna))
                {
                    Console.Clear();
                    Matriz();
                Console.WriteLine("felicidades ganastes");
                Program.jugadas = false;
                    
                }
            }
            if(Program.jugadas){
            
                iaCoordenada = ia.jugada();
                matriz[iaCoordenada.Fila, iaCoordenada.Columna] = ia.turno;
                Console.Clear();
                Matriz();
                if(validador.Verificar(iaCoordenada.Fila, iaCoordenada.Columna)) {
                    Console.Clear();
                    Console.WriteLine("Gano la maquina, f por ti");
                    Matriz();
                    Program.jugadas = false;
                }
            }
            
            
        }

        public void SinCasillas()
        {
            if(ia.coProhibida.Count == 9) Program.jugadas = false;
        }

        public void rellenar()  //rellena los espacios vacios con * y rellena la lista que contiene todas las coordenadas
        {
            for(int i= 0; i<3;i++)
            {
                for(int j= 0; j<3;j++)
                {
                    unico++;
                    if(matriz[i,j] != 'x' && matriz[i,j] != 'o') matriz[i,j] = '*';// si no es una x y o rellena con *
                    if(unico < 9) 
                        ia.Todas.Add(new coordenada(i,j));
                }
                
            }
        }
    }
}
