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
        public Fisica(bool tieneHuellas, DateTime fechaRecoleccion, string descripcion) : base (fechaRecoleccion, descripcion)
        {
            TieneHuellasDigitales = tieneHuellas;
        }

        // POLIMORFISMO
        public override string ToString()
        {
            if (TieneHuellasDigitales)
            {
                return $"\n < La evidencia TIENE huellas del SOSPECHOSO > ";
            }

            return $"\n < La evidencia NO tiene huellas del SOSPECHOSO > ";
        }

    }
}
