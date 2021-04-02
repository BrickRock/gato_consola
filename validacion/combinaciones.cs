using System;
using System.Collections.Generic;

namespace programa01
{
    public partial class Validacion
    {
        
        public void DefinirCombinaciones()
        {

        }
    }

    public class Combinacion
    {
        coordenada x,y,z;
        public Combinacion(coordenada x, coordenada y, coordenada z)
        {
            (this.x, this.y, this.z) = (x, y, z);
        }

        public bool compararCoords()
        {
            if((x.Fila, x.Columna)==(y.Fila, y.Columna)==(z.Fila, z.Columna)) return true;
            else return false;
        }
    }
}