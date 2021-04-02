using System;
using System.Collections.Generic;

namespace programa01
{
    public class validar
    {   //                                                               VALIDACION DE LAS 4 ESQUINAS
        public List<coordenada> VEsquinaSI = new List<coordenada>();
        List<coordenada> VEsquinaSD = new List<coordenada>();
        List<coordenada> VEsquinaII = new List<coordenada>();
        List<coordenada> VEsquinaID = new List<coordenada>();

        //                                                              VALIDACION DE LOS 4 CENTROS LATERALES
        List<coordenada> VCentroS = new List<coordenada>();
        List<coordenada> VCentroD = new List<coordenada>(); 
        List<coordenada> VCentroI = new List<coordenada>(); 
        List<coordenada> VCentroB = new List<coordenada>(); 

        public void PosiblesGanadores()
        {   // Combinaciones esquina superior izquierda
            for(int i=0; i< 3; i++ )
            {
                VEsquinaSI.Add(new coordenada(0,i));
            }
            for(int i=0; i< 3; i++ )
            {
                VEsquinaSI.Add(new coordenada(i,0));
            }
            for(int i=0; i< 3; i++ )
            {
                VEsquinaSI.Add(new coordenada(i,i));
            }
            //Combinaciones esquina superior derecha
            for(int i=2; i > -1; i-- )
            {
                VEsquinaSD.Add(new coordenada(0,i));
            }
            for(int i=0; i < 3; i++ )
            {
                VEsquinaSD.Add(new coordenada(i,2));
            }
            int bajada = 3;
            for(int i=0; i < 3; i++ )
            {
                bajada -= 1;
                VEsquinaSD.Add(new coordenada(i,bajada));
            }
            //combinaciones de esquina inferior izquierda
            for(int i=2; i > -1; i-- )
            {
                VEsquinaSD.Add(new coordenada(0,i));
            }
        }



    }
}