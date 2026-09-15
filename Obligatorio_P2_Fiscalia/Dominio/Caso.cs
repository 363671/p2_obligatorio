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

        // CONSTRUCTOR
        public Caso()
        {
            Id = ++UltimoId;
            ValidarTipoInvestigador();
        }

        public Caso(string nombre, string descripcion, bool activo, Sospechoso sospechoso, Investigador investigadorD)
        {
            Id = ++UltimoId;
            Nombre = nombre;
            Descripcion = descripcion;
            Activo = activo;
            SospechosoPrincipal = sospechoso;
            InvestigadorD = investigadorD;
            ValidarTipoInvestigador();
        }

        // MÉTODOS
        public void AgregarEvidencia(Evidencia e)
        {
            _evidenciasDelCaso.Add(e);
        }

        // Valida que el Investigador a asignar al Caso sea Detective
        private void ValidarTipoInvestigador()
        {
            if(InvestigadorD.Rol == Rol.Fiscal)
            {
                Console.WriteLine("");
                throw new Exception(" < Ha ocurrido un error / Investigador es Fiscal, no Detective / > ");
            }
        }

        // Aprovechando POLIMORFISMO

        public override string ToString()
        {
            string datosCaso = "------------------------------------------------------------------------";

            datosCaso += $" Caso: \n";
            datosCaso += $"  -> Id: {Id} Nombre: {Nombre} \n";
            datosCaso += $"  -> Descripcion: {Descripcion} \n";
            datosCaso += $"";
            datosCaso += $"  -> Sospechoso: <- \n";
            datosCaso += $"  --> CI: {SospechosoPrincipal.Cedula} \n";
            datosCaso += $"  --> Nombre: {SospechosoPrincipal.Nombre} \n";
            datosCaso += $"  --> Fecha Nac.: {SospechosoPrincipal.FechaNacimiento} \n";
            datosCaso += $"  -> Investigador: <- \n";
            datosCaso += $"  --> Nombre: {InvestigadorD.Nombre} \n";
            datosCaso += $"  --> Mail: {InvestigadorD.Mail} \n";
            datosCaso += $"  --> Rol: {InvestigadorD.Rol} \n";
            datosCaso += $"------------------------------------------------------------------------";

            return datosCaso;
        }

        public override bool Equals(object? obj)
        {
            return obj is Caso caso && Id == caso.Id;
        }

    }
}
