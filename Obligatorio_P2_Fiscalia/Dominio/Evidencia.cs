using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class Evidencia
    {
        // ATRIBUTOS y PROPERTIES
        public static int UltimoId { get; set; } = 0;
        public int Id { get; set; }
        public DateTime FechaRecoleccion { get; set; }
        public string Descripcion { get; set; }


        // ctor
        public Evidencia()
        {
            Id = ++UltimoId;
        }

        public Evidencia(DateTime fechaRecoleccion, string descripcion)
        {
            Id = ++UltimoId;
            FechaRecoleccion = fechaRecoleccion;
            Descripcion = descripcion;
            ValidarDatos();
        }

        // METODOS

        public void ValidarDatos()
        {
            ValidarFechaRecoleccion();
            ValidarDescripcion();
        }

        private void ValidarFechaRecoleccion()
        {
            throw new NotImplementedException();
        }

        private void ValidarDescripcion()
        {
            string errores = "";

            if (Descripcion.IsWhiteSpace())
            {
                errores += "El largo de la Descripcion no puede ser nulo.";

            }

            if (Descripcion.Length < 20)
            {
                errores += "El largo de la Descripcion no puede ser menor a 20 caracteres.";

            }

            if (errores != "")
            {
                Console.WriteLine("");
                throw new Exception(" < Ha ocurrido un error / Descripcion / > ");
            }
        }

        // Aprovechando POLIMORFISMO
        public override string ToString()
        {
            string datosSospechoso = "";

            datosSospechoso += $" Evidencia -> Id: {Id} Recolectado: {FechaRecoleccion} Descripcion: {Descripcion}\n\n";

            return datosSospechoso;
        }


    }
}
