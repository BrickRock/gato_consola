using System;

namespace programa01
{
    partial class Validacion
    {
        public bool Centro() // verifica la casilla central
        {
            bool comparacion;
            Combinacion CENTRO = guardaCoords[obtenerCombinaciones.diagonalI];
            comparacion = CENTRO.compararCoords(array);
            if(comparacion) return true;
            CENTRO = guardaCoords[obtenerCombinaciones.diagonalD];
            comparacion = CENTRO.compararCoords(array);
            if(comparacion) return true;
            CENTRO = guardaCoords[obtenerCombinaciones.fila2];
            comparacion = CENTRO.compararCoords(array);
            if(comparacion) return true;
            CENTRO = guardaCoords[obtenerCombinaciones.columna2];
            comparacion = CENTRO.compararCoords(array);
            if(comparacion) return true;
            return false;
        }
    }
}