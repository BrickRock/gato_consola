using System;
using System.Collections;

namespace programa01
{
    public class validar_esquina:IEnumerator
    {
        private char[,] arrayLocal;
        private int columna, fila;
        public validar_esquina(char[,] array)
        {
            arrayLocal = array;
            columna = jugador.Columna;
            fila = jugador.Fila;
            columna= -1;
        }

        public bool MoveNext()
        {
            columna++;
            ValidarAbajo();
            System.Console.WriteLine("la columna vale {0} y la fila vale {1}",columna,fila);
            return(columna<3);
            
        }

        public void Reset()
        {

        }

        public object Current{ get => arrayLocal[columna,fila];}

        private void ValidarDerecha()
        {
            System.Console.WriteLine("me llamo una vez");
            for(int i = 0; i<2;i++)
            {
            columna++;
            }
        }

        private void ValidarAbajo()
        {
            
            for(int i= 1; i<3 ;i++)
            {
                
                fila += 1;
                System.Console.WriteLine(fila);
            }
        }

        private void ValidarDiagonal()
        {
            for(int i= 0;i<3;i++)
            {
                fila++;
                columna++;
            }
        }
    }
}