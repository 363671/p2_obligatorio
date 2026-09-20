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
            string evidencia = " ----------------- Evidencia > Fisica ----------------- ";

            if (TieneHuellasDigitales)
            {
                evidencia += $"\n     | La evidencia TIENE huellas del SOSPECHOSO | \n";
                evidencia += base.ToString();
                return evidencia;
            }

            evidencia += $"\n     | La evidencia NO tiene huellas del SOSPECHOSO | \n";
            evidencia += base.ToString();
            
            return evidencia;
        }

    }
}
