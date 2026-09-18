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
        public Grabacion()
        {
        
        }

        public Grabacion(int calidad, bool inFraganti, DateTime fechaRecoleccion, string descripcion) : base(fechaRecoleccion, descripcion)
        {
            Calidad = calidad;
            InFraganti = inFraganti;
            ValidarDatos();
        }

        // Se genera el método general ValidarDatos() como buena practica
        public void ValidarDatos()
        {
            ValidarCalidad();
        }

        private void ValidarCalidad()
        {
            if (Calidad < 1 || Calidad > 5 )
            {
                throw new Exception(" < Ha ocurrido un error / Calidad Grabacion / > ");
            }
        }

        // POLIMORFISMO
        public override string ToString()
        {
            string resultado = $"\n < La CALIDAD es {Calidad} de 5 > \n";

            if (InFraganti)
            {
                return resultado += $"\n < La GRABACION fue InFraganti > \n";
            }

            return resultado += $"\n < La GRABACION NO fue InFraganti > \n";
        }

        //
    }
}
