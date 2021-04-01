using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace programa01
{
    public class tablero 
    {
        public char[,] matriz = new char[3,3];
        char turno;
        int unico = -1;
        
        public void Matriz()  // imprime el array en forma de matriz
        {
            for(int i= 0; i<3;i++)
            {
                for(int j= 0; j<3;j++)
                {
                    
                    Console.Write("  ");
                    Console.Write(matriz[i,j]);
                    
                        
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void dibujar() //pide al jugador ingresar los datos y los guarda en el array 
        {
            coordenada iaCoordenada;
            rellenar();
            jugador.imput();
            matriz[jugador.Fila, jugador.Columna] = jugador.turno; // en la posicion que elegio el jugador asigno la x
            
            iaCoordenada = ia.jugada();
            matriz[iaCoordenada.Fila, iaCoordenada.Columna] = ia.turno;
            
            
        }

        public void rellenar()  //rellena los espacios vacios con * y rellena la lista que contiene todas las coordenadas
        {
            for(int i= 0; i<3;i++)
            {
                for(int j= 0; j<3;j++)
                {
                    unico++;
                    if(matriz[i,j] != 'x' && matriz[i,j] != 'o') matriz[i,j] = '*';
                    if(unico < 9) 
                        ia.Todas.Add(new coordenada(i,j));
                }
                
            }
        }
    }
}
