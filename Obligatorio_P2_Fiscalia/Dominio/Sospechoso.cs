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

        // CTOR
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
        public void ValidarDatos()
        {
            ValidarCedula();
            ValidarNombre();
            ValidarFechaNacimiento();
        }

        private void ValidarCedula()
        {
            if (Cedula.IsWhiteSpace())
            {
                throw new Exception(" < El largo de la CI no puede ser nulo. > ");
            }

            if (Cedula.Length < 9)
            {
                throw new Exception(" < El largo de la CI no puede ser menor a 9 caracteres. > ");
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

        public string AntecedentesAString(bool antec)
        {
            if (antec)
            {
                return "SI";
            }

            return "NO";
        }

        // POLIMORFISMO
        

        public override string ToString()
        {
            string datosSospechoso = "";
            datosSospechoso += $"  Sospechoso: \n";
            datosSospechoso += $"   -> CI: {Cedula} \n";
            datosSospechoso += $"   -> Nombre: {Nombre} \n";
            datosSospechoso += $"   -> Nac.: {FechaNacimiento} \n";
            datosSospechoso += $"   -> Tiene Antec.: {AntecedentesAString(TieneAntecedentes)} \n";

            return datosSospechoso;
        }

        public override bool Equals(object? obj)
        {
            return obj is Sospechoso sosp && Cedula == sosp.Cedula;
        }

    }
}
