using System;

namespace programa01
{
    public partial class Validacion
    {
        public bool EsquinaSI()
        {
            bool comparacion;
            Combinacion Esquina = guardaCoords[obtenerCombinaciones.fila1];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.columna1];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.diagonalI];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            return false;
        }

        public bool EsquinaSD()
        {
            bool comparacion;
            Combinacion Esquina = guardaCoords[obtenerCombinaciones.fila1];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.columna3];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.diagonalD];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            return false;
        }

        public bool EsquinaII()
        {
            bool comparacion;
            Combinacion Esquina = guardaCoords[obtenerCombinaciones.fila3];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.columna1];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.diagonalD];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            return false;
        }

        public bool EsquinaID()
        {
            bool comparacion;
            Combinacion Esquina = guardaCoords[obtenerCombinaciones.fila3];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.columna3];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            Esquina = guardaCoords[obtenerCombinaciones.diagonalI];
            comparacion = Esquina.compararCoords(array);
            if(comparacion) return true;
            return false;
        }
        
    }
}