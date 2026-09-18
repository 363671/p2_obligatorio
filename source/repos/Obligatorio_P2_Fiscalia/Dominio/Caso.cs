using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Caso
    {
        // ATRIBUTOS y PROPERTIES
        public static int UltimoId { get; set; } = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public Sospechoso SospechosoPrincipal { get; set; }
        public Investigador InvestigadorD { get; set; }
        public List<Evidencia> _evidenciasDelCaso { get; set; } = new List<Evidencia>();

        // CTOR
        public Caso()
        {
            Id = ++UltimoId;
            ValidarDatos();
        }

        public Caso(string nombre, string descripcion, bool activo, Sospechoso sospechoso, Investigador investigadorD)
        {
            Id = ++UltimoId;
            Nombre = nombre;
            Descripcion = descripcion;
            Activo = activo;
            SospechosoPrincipal = sospechoso;
            InvestigadorD = investigadorD;
            ValidarDatos();
        }

        public void AgregarEvidencia(Evidencia e)
        {
            _evidenciasDelCaso.Add(e);
        }

        private void ValidarDatos()
        {
            //ValidarActivo();
            //ValidarSospechoso();
            ValidarInvestigador();
        }

        //private void ValidarActivo()
        //{
        //    throw new Exception(" < > ");

        //}

        //private void ValidarSospechoso()
        //{
        //    throw new Exception(" < > ");
        //}

        private void ValidarInvestigador()
        {
            if(InvestigadorD.Rol == Rol.Fiscal)
            {
                Console.WriteLine("");
                // throw new Exception(" < Ha ocurrido un error / Investigador es Fiscal, no Detective / > ");
            }
        }

        // Aprovechando POLIMORFISMO

        public override string ToString()
        {
            string datosCaso = "\n------------------------------------------------------------------------";

            datosCaso += $"\n Caso: \n";
            datosCaso += $"  -> Id: {Id} Nombre: {Nombre} \n";
            datosCaso += $"  Descripcion: {Descripcion} \n";
            datosCaso += $"  Sospechoso: \n";
            datosCaso += $"   -> CI: {SospechosoPrincipal.Cedula} \n";
            datosCaso += $"   -> Nombre: {SospechosoPrincipal.Nombre} \n";
            datosCaso += $"   -> Nac.: {SospechosoPrincipal.FechaNacimiento} \n";
            datosCaso += $"   -> Tiene Antec.: {SospechosoPrincipal.TieneAntecedentes} \n";
            datosCaso += $"  Evidencias: \n";

            for (int i = 0; i < _evidenciasDelCaso.Count(); i++)
            {
                datosCaso += "    " + _evidenciasDelCaso[i].ToString();
            }
            
            return datosCaso;
        }

        public override bool Equals(object? obj)
        {
            return obj is Caso caso && Nombre == caso.Nombre;
        }

    }
}
