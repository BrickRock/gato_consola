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
                    unico++;
                    Console.Write("  ");
                    Console.Write(matriz[i,j]);
                    if(unico < 9) 
                        ia.Todas.Add(new coordenada(i,j));
                        
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void dibujar() //pide al jugador ingresar los datos y los guarda en el array 
        {
            jugador.imput();
            matriz[jugador.Fila, jugador.Columna] = jugador.turno;
            rellenar();
            
            
        }

        public void rellenar()  //rellena los espacios vacios con *
        {
            for(int i= 0; i<3;i++)
            {
                for(int j= 0; j<3;j++)
                {
                    if(matriz[i,j] != 'x') matriz[i,j] = '*';
                }
                
            }
        }
    }
}
