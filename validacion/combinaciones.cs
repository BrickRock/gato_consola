using System;
using System.Collections;
using System.Collections.Generic;

namespace programa01
{
    public partial class Validacion
    {
        
        enum obtenerCombinaciones{
            fila1 = 1, fila2 = 2, fila3 =3,
            columna1 = 4,columna2 = 5, columna3= 6,

            diagonalD =7, diagonalI=8
        }

        
        Dictionary<obtenerCombinaciones, Combinacion> guardaCoords = new Dictionary<obtenerCombinaciones, Combinacion>();
        public void DefinirCombinaciones()
        {   //aqui inician las filas
            guardaCoords.Add(obtenerCombinaciones.fila1, new Combinacion(new coordenada(0,0), new coordenada(0,1), new coordenada(0,2)));
            guardaCoords.Add(obtenerCombinaciones.fila2, new Combinacion(new coordenada(1,0), new coordenada(1,1), new coordenada(1,2)));
            guardaCoords.Add(obtenerCombinaciones.fila3, new Combinacion(new coordenada(2,0), new coordenada(2,1), new coordenada(2,2)));
            //aqui inician las columnas
            guardaCoords.Add(obtenerCombinaciones.columna1, new Combinacion(new coordenada(0,0), new coordenada(1,0), new coordenada(2,0)));
            guardaCoords.Add(obtenerCombinaciones.columna2, new Combinacion(new coordenada(0,1), new coordenada(1,1), new coordenada(2,1)));
            guardaCoords.Add(obtenerCombinaciones.columna3, new Combinacion(new coordenada(0,2), new coordenada(1,2), new coordenada(2,2)));
            //aqui inician las diagonales
            guardaCoords.Add(obtenerCombinaciones.diagonalI, new Combinacion(new coordenada(0,0), new coordenada(1,1), new coordenada(2,2)));
            guardaCoords.Add(obtenerCombinaciones.diagonalD, new Combinacion(new coordenada(0,2), new coordenada(1,1), new coordenada(2,0)));
        }
    }

    public class Combinacion
    {
        coordenada x,y,z;
        public Combinacion(coordenada x, coordenada y, coordenada z)
        {
            (this.x, this.y, this.z) = (x, y, z);
        }

        public bool compararCoords(char[,] array)
        {
            if(array[x.Fila, x.Columna] == array[y.Fila, y.Columna] && array[y.Fila, y.Columna] == array[z.Fila, z.Columna]) return true;
            else return false;
        }
    }
}