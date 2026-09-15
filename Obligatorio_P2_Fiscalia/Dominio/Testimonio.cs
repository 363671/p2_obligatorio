using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class Testimonio : Evidencia
    {
        // CLASE HIJA de EVIDENCIA

        // PROPERTIES
        public string NombreTestigo { get; set; }
        public Credibilidad IndiceCredibilidad { get; set; }

        // CTOR
        public Testimonio(string nombreTestigo, Credibilidad indiceCredibilidad)
        {
            NombreTestigo = nombreTestigo;
            IndiceCredibilidad = indiceCredibilidad;
        }

        public void ValidarDatos()
        {
            ValidarNombreTestigo();
            ValidarIndiceCredibilidad();

        }

        private void ValidarNombreTestigo()
        {
            string errores = "";

            if (NombreTestigo.IsWhiteSpace())
            {
                errores += "El largo del Nombre del Testigo no puede ser nulo.";

            }

            if (NombreTestigo.Length > 90)
            {
                errores += "El largo del Nombre del Testigo no puede superar los 90 caracteres.";

            }

            if (errores != "")
            {
                Console.WriteLine("");
                throw new Exception(" < Ha ocurrido un error / Nombre Testigo / > ");
            }
        }

        // revisar redundancia
        private void ValidarIndiceCredibilidad()
        {
            if(IndiceCredibilidad != Credibilidad.Bajo)
            {
                Console.WriteLine("");
                throw new Exception(" < Ha ocurrido un error / Credibilidad / > ");
            }
        }
    }
}
