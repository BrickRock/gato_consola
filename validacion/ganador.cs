using System;
using System.Collections.Generic;

namespace programa01
{
    public partial class Validacion
    {
        char[,] array;
        enum lugar{
            EsquinaSD=1, EsquinaSI=2, EsquinaII=3, EsquinaID =4,  //Esquinas
            CentroD=5, CentroI = 6, CentroS = 7, CentroB = 8, // CENTROS

        }
        public Validacion(char[,] matriz) 
        {
            array = matriz;
        } 
        public bool Verificar(int fila, int columna)
        {   //validacion de esquinas
            if((0,0)==(fila, columna)) return EsquinaSI();
            else if((2,0)==(fila, columna)) return EsquinaII();
            else if((0,2)==(fila, columna)) return EsquinaSD();
            else if((2,2)==(fila, columna)) return EsquinaID();
            //validacion de centros
            if((0,1)==(fila, columna)) return CentroS();
            else if((1,2)==(fila, columna)) return CentroD();
            else if((2,1)==(fila, columna)) return CentroB();
            else if((1,0)==(fila, columna)) return CentroI();
            // casilla central
            if((2,2) == (fila, columna)) return Centro();
            else return false;
        }
    }
}