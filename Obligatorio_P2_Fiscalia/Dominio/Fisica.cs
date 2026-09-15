using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Fisica : Evidencia
    {
        // CLASE HIJA de EVIDENCIA
        
        // PROPERTIES
        public bool TieneHuellasDigitales { get; set; }

        // CTOR
        public Fisica(bool tieneHuellas)
        {
            TieneHuellasDigitales = tieneHuellas;
        }



    }
}
