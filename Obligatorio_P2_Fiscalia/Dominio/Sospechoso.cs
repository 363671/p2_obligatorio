using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Sospechoso
    {
        // ATRIBUTOS y PROPERTIES

        public static int UltimoId { get; set; } = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool TieneAntecedentes { get; set; }

        // ctor
        public Sospechoso()
        {
            Id = ++UltimoId;
            ValidarDatos();
        }
        
        public Sospechoso(string nombre, string cedula, DateTime fechaNacimiento, bool tieneAntecedentes)
        {
            Id = ++UltimoId;
            Nombre = nombre;
            Cedula = cedula;
            FechaNacimiento = fechaNacimiento;
            TieneAntecedentes = tieneAntecedentes;
            ValidarDatos();
        }

        // METODOS
        private void ValidarDatos()
        {
            ValidarCedula();
            ValidarNombre();
            ValidarFechaNacimiento();
        }

        private void ValidarCedula()
        {
            string errores = "";

            if (Cedula.IsWhiteSpace())
            {
                errores += "El largo de la CI no puede ser nulo.";

            }

            if (Cedula.Length < 9)
            {
                errores += "El largo de la CI no puede ser menor a 9 caracteres.";

            }

            if (Cedula[Cedula.Length - 2] != '-')
            {
                errores += "El penultimo caracter de la CI debe ser un guion (-).";

            }

            if (errores != "")
            {
                Console.WriteLine("");
                throw new Exception(" < Ha ocurrido un error / CI / > ");
            }
        }

        private void ValidarNombre()
        {
            string errores = "";

            if (Nombre.IsWhiteSpace())
            {
                errores += "El largo del nombre no puede ser nulo.";

            }

            if (Nombre.Length > 90)
            {
                errores += "El largo del nombre no puede superar los 90 caracteres.";

            }

            if (errores != "")
            {
                Console.WriteLine("");
                throw new Exception(" < Ha ocurrido un error / Nombre / > ");
            }
        }

        private void ValidarFechaNacimiento()
        {
            string errores = "";

            //if (FechaNacimiento == null)
            //{
            //    errores += "Fecha de Nacimiento invalida";
            //}

            if (FechaNacimiento >= DateTime.Today)
            {
                errores += "Fecha de Nacimiento invalida";
            }

            if (errores != "")
            {
                Console.WriteLine("");
                throw new Exception(" < Ha ocurrido un error / Fecha de Nacimiento / > ");
            }
        }

        // Aprovechando POLIMORFISMO

        public override string ToString()
        {
            string datosSospechoso = "";

            datosSospechoso += $" Sospechoso -> Id: {Id} Nombre: {Nombre} CI: {Cedula} Nacimiento: {FechaNacimiento} Tiene antecedentes: {TieneAntecedentes} \n\n";

            return datosSospechoso;
        }

        public override bool Equals(object? obj)
        {
            return obj is Sospechoso sosp && Cedula == sosp.Cedula;
        }



    }
}
