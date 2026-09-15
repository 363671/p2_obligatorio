using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Grabacion : Evidencia
    {
        // CLASE HIJA de EVIDENCIA

        // PROPERTIES
        public int Calidad { get; set; }
        public bool InFraganti { get; set; }

        // CTOR
        public Grabacion(int calidad, bool inFraganti)
        {
            Calidad = calidad;
            InFraganti = inFraganti;
            ValidarDatos();
        }

        public void ValidarDatos()
        {
            ValidarCalidad();
            ValidarInFraganti();

        }

        private void ValidarCalidad()
        {
            if (Calidad < 1 || Calidad > 5 )
            {
                throw new Exception(" < Ha ocurrido un error / Calidad Grabacion / > ");
            }
        }
        
        private void ValidarInFraganti()
        {
            //if (InFraganti)
            //{
            //    throw new Exception(" < Ha ocurrido un error / InFraganti Grabacion / > ");
            //}
        }
    }
}
