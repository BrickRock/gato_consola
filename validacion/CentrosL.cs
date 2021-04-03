using System;

namespace programa01
{
    partial class Validacion
    {
        public bool CentroI() // CENTRO IZQUIERDO
        {
            bool comparacion;
            Combinacion Centro = guardaCoords[obtenerCombinaciones.fila2];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            Centro = guardaCoords[obtenerCombinaciones.columna1];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            return false;
        }

        public bool CentroD() // CENTRO DERECHA
        {
            bool comparacion;
            Combinacion Centro = guardaCoords[obtenerCombinaciones.fila2];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            Centro = guardaCoords[obtenerCombinaciones.columna3];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            return false;
        }

        public bool CentroS() // CENTRO SUPERIOR
        {
            bool comparacion;
            Combinacion Centro = guardaCoords[obtenerCombinaciones.fila1];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            Centro = guardaCoords[obtenerCombinaciones.columna2];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            return false;
        }

        public bool CentroB() // CENTRO BAJO O CENTRO INFERIOR
        {
            bool comparacion;
            Combinacion Centro = guardaCoords[obtenerCombinaciones.fila3];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            Centro = guardaCoords[obtenerCombinaciones.columna2];
            comparacion = Centro.compararCoords(array);
            if(comparacion) return true;
            return false;
        }
    }
}