using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Dominio
{
    public class Sistema
    {
        // ATRIBUTOS y PROPERTIES
        public List<Investigador> _investigadores { get; } = new List<Investigador>();

        public List<Sospechoso> _sospechosos { get; } = new List<Sospechoso>();
        public List<Caso> _casos { get; } = new List<Caso>();
        public List<Evidencia> _evidencias { get; } = new List<Evidencia>();

        
        public void PrecargarDatos()
        {
        
        }

        public void PrecargarInvestigadores()
        {
            Investigador i1 = new Investigador("Sherlock@go.ar", "pass", "Sherlock Holmes", Rol.Detective);
            Investigador i2 = new Investigador("Sherlock@go.ar", "pass", "Sherlock Holmes", Rol.Detective);
            AgregarInvestigador(i1);
            AgregarInvestigador(i2);
        }

        public void PrecargarSospechosos()
        {
            Sospechoso s1 = new Sospechoso("Paco", "111111111", new DateTime(01,01,2026), true);
            Sospechoso s2 = new Sospechoso("Peco", "222222222", new DateTime(01,02,2026), false);

        }

        public void PrecargarCasos()
        {
            
        }

        public void PrecargarEvidencias()
        {

        }
        
        public void AgregarInvestigador(Investigador i)
        {
            _investigadores.Add(i);
        }
        
        public void AgregarSospechoso(Sospechoso s)
        {
            _sospechosos.Add(s);
        }

        public void AgregarCaso(Caso c)
        {
            _casos.Add(c);
        }
        
        public void AgregarEvidencia(Evidencia e)
        {
            _evidencias.Add(e);
        }

        
    }
}
