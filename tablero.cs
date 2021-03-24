using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace programa01
{
    public class tablero
    {
        char[,] matriz = new char[3,3];
        char turno;
        Dictionary<int,char> Posibles_Escenarios= new Dictionary<int,char>(); 
        
        
        public void Matriz()
        {
            for(int i= 0; i<3;i++)
            {
                for(int j= 0; j<3;j++)
                {
                    Console.Write("  ");
                    Console.Write(matriz[i,j]);
                }
                System.Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void dibujar()
        {
            jugador.imput();
            matriz[jugador.Fila, jugador.Columna] = jugador.turno;
            rellenar();
            
        }

        public void rellenar()
        {
            for(int i= 0; i<3;i++)
            {
                for(int j= 0; j<3;j++)
                {
                    if(matriz[i,j] != 'x') matriz[i,j] = '*';
                }
                
            }
        }

        public void verficar()
        {
                    
        }

       
}
