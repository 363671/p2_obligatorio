using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dominio
{
    public class Sistema
    {
        // ATRIBUTOS y PROPERTIES
        private List<Investigador> _investigadores { get; } = new List<Investigador>();
        private List<Sospechoso> _sospechosos { get; } = new List<Sospechoso>();
        private List<Caso> _casos { get; } = new List<Caso>();
        private List<Evidencia> _evidencias { get; } = new List<Evidencia>();
        private static Sistema _instancia;
        
        // CTOR
        private Sistema()
        {
            PrecargarDatos();    
        }

        // PRECARGAS DE DATOS
        private void PrecargarDatos()
        {
            PrecargarFisicas();
            PrecargarGrabaciones();
            PrecargarTestimonios();
            PrecargarInvestigadores();
            PrecargarSospechosos();
            PrecargarCasos();
        }

        // Singleton
        // > Método que retorna una única instancia
        public static Sistema GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Sistema();
            }

            return _instancia;
        }
        
        // > Precargas concretas

        private void PrecargarInvestigadores()
        {
            Investigador i1 = new Investigador("sherlock@gmail.com", "Pass1234.", "Sherlock Holmes", Rol.Detective);
            Investigador i2 = new Investigador("watson@gmail.com", "Pass1234.", "John Watson", Rol.Detective);
            Investigador i3 = new Investigador("poirot@gmail.com", "Pass1234.", "Hercule Poirot", Rol.Detective);
            Investigador i4 = new Investigador("marlowe@gmail.com", "Pass1234.", "Philip Marlowe", Rol.Detective);
            Investigador i5 = new Investigador("spade@gmail.com", "Pass1234.", "Sam Spade", Rol.Detective);
            Investigador i6 = new Investigador("columbo@gmail.com", "Pass1234.", "Frank Columbo", Rol.Detective);
            Investigador i7 = new Investigador("holmes2@gmail.com", "Pass1234.", "Enola Holmes", Rol.Detective);
            Investigador i8 = new Investigador("marple@gmail.com", "Pass1234.", "Jane Marple", Rol.Detective);
            Investigador i9 = new Investigador("morse@gmail.com", "Pass1234.", "Inspector Morse", Rol.Detective);
            Investigador i10 = new Investigador("veras@gmail.com", "Pass1234.", "Elena Vera", Rol.Detective);

            Investigador i11 = new Investigador("fiscal1@gmail.com", "Pass1234.", "Carlos Rodríguez", Rol.Fiscal);
            Investigador i12 = new Investigador("fiscal2@gmail.com", "Pass1234.", "María González", Rol.Fiscal);
            Investigador i13 = new Investigador("fiscal3@gmail.com", "Pass1234.", "Javier Fernández", Rol.Fiscal);
            Investigador i14 = new Investigador("fiscal4@gmail.com", "Pass1234.", "Lucía Martínez", Rol.Fiscal);
            Investigador i15 = new Investigador("fiscal5@gmail.com", "Pass1234.", "Andrés Pereira", Rol.Fiscal);
            Investigador i16 = new Investigador("fiscal6@gmail.com", "Pass1234.", "Sofía Silva", Rol.Fiscal);
            Investigador i17 = new Investigador("fiscal7@gmail.com", "Pass1234.", "Diego Ramírez", Rol.Fiscal);
            Investigador i18 = new Investigador("fiscal8@gmail.com", "Pass1234.", "Valentina Torres", Rol.Fiscal);
            Investigador i19 = new Investigador("fiscal9@gmail.com", "Pass1234.", "Martín Cabrera", Rol.Fiscal);
            Investigador i20 = new Investigador("fiscal10@gmail.com", "Pass1234.", "Camila Suárez", Rol.Fiscal);

            AgregarInvestigador(i1);
            AgregarInvestigador(i2);
            AgregarInvestigador(i3);
            AgregarInvestigador(i4);
            AgregarInvestigador(i5);
            AgregarInvestigador(i6);
            AgregarInvestigador(i7);
            AgregarInvestigador(i8);
            AgregarInvestigador(i9);
            AgregarInvestigador(i10);
            AgregarInvestigador(i11);
            AgregarInvestigador(i12);
            AgregarInvestigador(i13);
            AgregarInvestigador(i14);
            AgregarInvestigador(i15);
            AgregarInvestigador(i16);
            AgregarInvestigador(i17);
            AgregarInvestigador(i18);
            AgregarInvestigador(i19);
            AgregarInvestigador(i20);
        }

        private void PrecargarSospechosos()
        {
            Sospechoso s1 = new Sospechoso("Juan Pérez", "11111111-1", new DateTime(1985, 3, 15), true);
            Sospechoso s2 = new Sospechoso("María González", "22222222-2", new DateTime(1992, 7, 22), false);
            Sospechoso s3 = new Sospechoso("Carlos Rodríguez", "33333333-3", new DateTime(1978, 11, 8), true);
            Sospechoso s4 = new Sospechoso("Laura Fernández", "44444444-4", new DateTime(1990, 1, 30), false);
            Sospechoso s5 = new Sospechoso("Martín Silva", "55555555-5", new DateTime(1982, 5, 17), true);
            Sospechoso s6 = new Sospechoso("Sofía Martínez", "66666666-6", new DateTime(1995, 9, 3), false);
            Sospechoso s7 = new Sospechoso("Diego Cabrera", "77777777-7", new DateTime(1975, 12, 19), true);
            Sospechoso s8 = new Sospechoso("Valentina López", "88888888-8", new DateTime(1988, 4, 26), false);
            Sospechoso s9 = new Sospechoso("Andrés Pereira", "99999999-9", new DateTime(1980, 8, 11), true);
            Sospechoso s10 = new Sospechoso("Camila Suárez", "10101010-0", new DateTime(1997, 2, 14), false);
            Sospechoso s11 = new Sospechoso("Federico Acosta", "12121212-1", new DateTime(1986, 6, 29), true);
            Sospechoso s12 = new Sospechoso("Natalia Méndez", "13131313-2", new DateTime(1993, 10, 7), false);
            Sospechoso s13 = new Sospechoso("Sebastián Torres", "14141414-3", new DateTime(1972, 3, 21), true);
            Sospechoso s14 = new Sospechoso("Paula Ramírez", "15151515-4", new DateTime(1989, 12, 5), false);
            Sospechoso s15 = new Sospechoso("Gonzalo Castro", "16161616-5", new DateTime(1991, 7, 18), true);

            Sospechoso s16 = new Sospechoso("Martín Cabrera", "17171717-1", new DateTime(1989, 3, 12, 0, 0, 0), false);
            Sospechoso s17 = new Sospechoso("Gabriela Ortiz", "18181818-1", new DateTime(1993, 6, 25, 0, 0, 0), true);
            Sospechoso s18 = new Sospechoso("Andrés Pereira", "19191919-1", new DateTime(1979, 10, 8, 0, 0, 0), false);
            Sospechoso s19 = new Sospechoso("Natalia Suárez", "20202020-2", new DateTime(1996, 1, 19, 0, 0, 0), true);
            Sospechoso s20 = new Sospechoso("Sebastián Ramos", "21212121-2", new DateTime(1984, 5, 27, 0, 0, 0), false);

            Sospechoso s21 = new Sospechoso("Carolina Méndez", "23232323-2", new DateTime(1999, 9, 4, 0, 0, 0), true);
            Sospechoso s22 = new Sospechoso("Nicolás Acosta", "24242424-2", new DateTime(1981, 12, 17, 0, 0, 0), false);
            Sospechoso s23 = new Sospechoso("Florencia Rojas", "25252525-2", new DateTime(1995, 4, 11, 0, 0, 0), true);
            Sospechoso s24 = new Sospechoso("Matías Sosa", "26262626-2", new DateTime(1990, 8, 23, 0, 0, 0), false);
            Sospechoso s25 = new Sospechoso("Romina Vázquez", "27272727-2", new DateTime(1987, 2, 6, 0, 0, 0), true);

            Sospechoso s26 = new Sospechoso("Gonzalo Medina", "28282828-2", new DateTime(1983, 7, 15, 0, 0, 0), false);
            Sospechoso s27 = new Sospechoso("Verónica Iglesias", "29292929-2", new DateTime(1992, 11, 2, 0, 0, 0), true);
            Sospechoso s28 = new Sospechoso("Alejandro Figueroa", "30303030-3", new DateTime(1977, 6, 29, 0, 0, 0), false);
            Sospechoso s29 = new Sospechoso("Mariana Domínguez", "31313131-3", new DateTime(1998, 10, 13, 0, 0, 0), true);
            Sospechoso s30 = new Sospechoso("Esteban Olivera", "32323232-3", new DateTime(1985, 1, 31, 0, 0, 0), false);

            AgregarSospechoso(s1);
            AgregarSospechoso(s2);
            AgregarSospechoso(s3);
            AgregarSospechoso(s4);
            AgregarSospechoso(s5);
            AgregarSospechoso(s6);
            AgregarSospechoso(s7);
            AgregarSospechoso(s8);
            AgregarSospechoso(s9);
            AgregarSospechoso(s10);
            AgregarSospechoso(s11);
            AgregarSospechoso(s12);
            AgregarSospechoso(s13);
            AgregarSospechoso(s14);
            AgregarSospechoso(s15);
            AgregarSospechoso(s16);
            AgregarSospechoso(s17);
            AgregarSospechoso(s18);
            AgregarSospechoso(s19);
            AgregarSospechoso(s20);
            AgregarSospechoso(s21);
            AgregarSospechoso(s22);
            AgregarSospechoso(s23);
            AgregarSospechoso(s24);
            AgregarSospechoso(s25);
            AgregarSospechoso(s26);
            AgregarSospechoso(s27);
            AgregarSospechoso(s28);
            AgregarSospechoso(s29);
            AgregarSospechoso(s30);
        }

        // Precarga de Evidencias
        // > Precarga de Grabaciones
        private void PrecargarGrabaciones()
        {
            Grabacion g1 = new Grabacion(1, true, new DateTime(2019, 3, 14), "Grabación de una persona ingresando al lugar del hecho.");
            Grabacion g2 = new Grabacion(4, false, new DateTime(2020, 8, 27), "Grabación de una cámara de seguridad del estacionamiento.");
            Grabacion g3 = new Grabacion(2, true, new DateTime(2021, 1, 9), "Grabación donde se observa al sospechoso manipulando una puerta.");
            Grabacion g4 = new Grabacion(5, false, new DateTime(2021, 11, 18), "Grabación de una cámara ubicada frente al domicilio.");
            Grabacion g5 = new Grabacion(3, true, new DateTime(2022, 5, 6), "Grabación del momento en que se produce el incidente.");
            Grabacion g6 = new Grabacion(1, false, new DateTime(2022, 12, 21), "Grabación de movimientos registrados en el acceso principal.");
            Grabacion g7 = new Grabacion(5, true, new DateTime(2023, 2, 13), "Grabación de alta calidad donde se identifica al sospechoso.");
            Grabacion g8 = new Grabacion(3, false, new DateTime(2023, 9, 30), "Grabación de una cámara de seguridad del comercio.");
            Grabacion g9 = new Grabacion(2, true, new DateTime(2024, 4, 17), "Grabación donde se observa una discusión entre varias personas.");
            Grabacion g10 = new Grabacion(4, false, new DateTime(2024, 10, 3), "Grabación correspondiente a una cámara del pasillo.");
            Grabacion g11 = new Grabacion(1, true, new DateTime(2025, 1, 25), "Grabación de una persona retirándose rápidamente del lugar.");
            Grabacion g12 = new Grabacion(5, false, new DateTime(2025, 6, 11), "Grabación de alta resolución obtenida de una cámara exterior.");
            Grabacion g13 = new Grabacion(3, true, new DateTime(2025, 11, 19), "Grabación donde se observa el ingreso no autorizado al edificio.");
            Grabacion g14 = new Grabacion(4, false, new DateTime(2026, 2, 7), "Grabación de una cámara ubicada en la entrada del edificio.");
            Grabacion g15 = new Grabacion(2, true, new DateTime(2026, 8, 16), "Grabación donde se observa al sospechoso abandonar la escena.");

            AgregarEvidencia(g1);
            AgregarEvidencia(g2);
            AgregarEvidencia(g3);
            AgregarEvidencia(g4);
            AgregarEvidencia(g5);
            AgregarEvidencia(g6);
            AgregarEvidencia(g7);
            AgregarEvidencia(g8);
            AgregarEvidencia(g9);
            AgregarEvidencia(g10);
            AgregarEvidencia(g11);
            AgregarEvidencia(g12);
            AgregarEvidencia(g13);
            AgregarEvidencia(g14);
            AgregarEvidencia(g15);
        }

        private void PrecargarFisicas()
        {
            Fisica f1 = new Fisica(true, new DateTime(2021, 3, 14), "Cuchillo con manchas de sangre encontrado en el lugar");
            Fisica f2 = new Fisica(false, new DateTime(2022, 7, 22), "Guante de cuero negro hallado cerca de una ventana");
            Fisica f3 = new Fisica(true, new DateTime(2023, 1, 9), "Vaso de vidrio con huellas dactilares parciales");
            Fisica f4 = new Fisica(false, new DateTime(2020, 11, 3), "Prenda de vestir encontrada abandonada en un vehículo");
            Fisica f5 = new Fisica(true, new DateTime(2024, 2, 18), "Teléfono celular encontrado debajo de una mesa");
            Fisica f6 = new Fisica(false, new DateTime(2019, 6, 27), "Llave metálica encontrada junto a la puerta trasera");
            Fisica f7 = new Fisica(true, new DateTime(2022, 10, 5), "Botella de vidrio con huellas visibles en la superficie");
            Fisica f8 = new Fisica(false, new DateTime(2025, 4, 11), "Mochila negra encontrada en las inmediaciones del lugar");
            Fisica f9 = new Fisica(true, new DateTime(2021, 12, 30), "Herramienta metálica con posibles huellas dactilares");
            Fisica f10 = new Fisica(false, new DateTime(2023, 5, 16), "Par de guantes de látex encontrados en un contenedor");
            Fisica f11 = new Fisica(true, new DateTime(2020, 8, 7), "Taza de cerámica con huellas dactilares parciales");
            Fisica f12 = new Fisica(false, new DateTime(2024, 9, 24), "Fragmento de vidrio encontrado junto a una ventana rota");
            Fisica f13 = new Fisica(true, new DateTime(2018, 4, 19), "Llave inglesa con posibles huellas en el mango");
            Fisica f14 = new Fisica(false, new DateTime(2025, 1, 28), "Campera encontrada en el asiento trasero de un automóvil");
            Fisica f15 = new Fisica(true, new DateTime(2023, 11, 12), "Lata metálica con huellas dactilares en la superficie");

            AgregarEvidencia(f1);
            AgregarEvidencia(f2);
            AgregarEvidencia(f3);
            AgregarEvidencia(f4);
            AgregarEvidencia(f5);
            AgregarEvidencia(f6);
            AgregarEvidencia(f7);
            AgregarEvidencia(f8);
            AgregarEvidencia(f9);
            AgregarEvidencia(f10);
            AgregarEvidencia(f11);
            AgregarEvidencia(f12);
            AgregarEvidencia(f13);
            AgregarEvidencia(f14);
            AgregarEvidencia(f15);
        }
        private void PrecargarTestimonios()
        {
            Testimonio t1 = new Testimonio("Gandalf", Credibilidad.Bajo, new DateTime(2024, 1, 17), "Afirma haber visto al sospechoso ingresar al lugar del crimen");
            Testimonio t2 = new Testimonio("María Rodríguez", Credibilidad.Alto, new DateTime(2023, 5, 22), "Declara haber escuchado una discusión proveniente del domicilio durante la noche");
            Testimonio t3 = new Testimonio("Carlos Méndez", Credibilidad.Medio, new DateTime(2025, 3, 8), "Manifiesta haber visto un vehículo estacionado frente al lugar de los hechos");
            Testimonio t4 = new Testimonio("Laura Fernández", Credibilidad.Alto, new DateTime(2022, 11, 14), "Afirma haber visto a la víctima reunirse con una persona desconocida horas antes del crimen");
            Testimonio t5 = new Testimonio("Roberto Silva", Credibilidad.Bajo, new DateTime(2024, 7, 3), "Recuerda haber observado movimientos extraños cerca de la escena del crimen");
            Testimonio t6 = new Testimonio("Ana Pereira", Credibilidad.Medio, new DateTime(2021, 9, 27), "Declara haber escuchado un fuerte ruido proveniente del edificio durante la madrugada");
            Testimonio t7 = new Testimonio("Diego Martínez", Credibilidad.Alto, new DateTime(2025, 6, 19), "Afirma haber identificado al sospechoso caminando por la zona poco antes del incidente");
            Testimonio t8 = new Testimonio("Sofía Cabrera", Credibilidad.Medio, new DateTime(2023, 2, 11), "Manifiesta haber visto a la víctima salir del establecimiento acompañada");
            Testimonio t9 = new Testimonio("Fernando López", Credibilidad.Bajo, new DateTime(2020, 12, 5), "Declara haber visto una persona correr por una calle cercana a la escena");
            Testimonio t10 = new Testimonio("Valentina Suárez", Credibilidad.Alto, new DateTime(2024, 10, 29), "Afirma haber recibido información sobre una discusión ocurrida horas antes del crimen");
            Testimonio t11 = new Testimonio("Martín Castro", Credibilidad.Medio, new DateTime(2022, 4, 16), "Declara haber observado un automóvil abandonar rápidamente el lugar de los hechos");
            Testimonio t12 = new Testimonio("Lucía Gómez", Credibilidad.Alto, new DateTime(2025, 8, 7), "Afirma haber visto al sospechoso ingresar al edificio durante la tarde");
            Testimonio t13 = new Testimonio("Javier Torres", Credibilidad.Bajo, new DateTime(2021, 1, 23), "Manifiesta haber escuchado voces provenientes de una habitación cercana");
            Testimonio t14 = new Testimonio("Camila Núñez", Credibilidad.Medio, new DateTime(2023, 8, 31), "Declara haber visto a una persona desconocida abandonar el lugar poco después del incidente");
            Testimonio t15 = new Testimonio("Andrés Romero", Credibilidad.Alto, new DateTime(2024, 12, 12), "Afirma haber reconocido la vestimenta del sospechoso al observar las cámaras de seguridad");
            
            AgregarEvidencia(t1);
            AgregarEvidencia(t2);
            AgregarEvidencia(t3);
            AgregarEvidencia(t4);
            AgregarEvidencia(t5);
            AgregarEvidencia(t6);
            AgregarEvidencia(t7);
            AgregarEvidencia(t8);
            AgregarEvidencia(t9);
            AgregarEvidencia(t10);
            AgregarEvidencia(t11);
            AgregarEvidencia(t12);
            AgregarEvidencia(t13);
            AgregarEvidencia(t14);
            AgregarEvidencia(t15);
        }

        private void PrecargarCasos()
        {
            
        }

        //////////////////// AGREGAR A LAS LISTAS DE DATOS ////////////////////

        // > Agregar Investigador
        private void AgregarInvestigador(Investigador i)
        {
            if (!_investigadores.Contains(i))
            {
                _investigadores.Add(i);
                return;
            }

            throw new Exception(" < Ha ocurrido un error / El mail ingresado ya está asociado a un Investigador / > ");
        }

        // > Agregar Evidencia
        private void AgregarEvidencia(Evidencia e)
        {
            _evidencias.Add(e);
        }

        // > Agregar Sospechoso
        private void AgregarSospechoso(Sospechoso s)
        {
            if (!_sospechosos.Contains(s))
            {
                _sospechosos.Add(s);
                return;
            }

            throw new Exception(" < Ha ocurrido un error / La CI ingresada ya está asociada a un Sospechoso / > ");
        }

        // > Agregar Caso
        private void AgregarCaso(Caso c)
        {
            if (!_casos.Contains(c))
            {
                _casos.Add(c);
                return;
            }

            throw new Exception(" < Ha ocurrido un error / Ya hay un Caso con el nombre ingresado / > ");
        }

        //////////////////// RETORNAR LAS LISTAS DE DATOS ////////////////////

        public List<Caso> GetCasos()
        {
            return _casos;
        }

        public List<Investigador> GetInvestigadores()
        {
            return _investigadores;
        }
        public List<Sospechoso> GetSospechosos()
        {
            return _sospechosos;
        }
        public List<Evidencia> GetEvidencias()
        {
            return _evidencias;
        }

        /////////////// RETORNAR INVESTIGADOR POR MAIL ///////////////
        public Investigador GetInvestigadorPorMail(string mail)
        {
            Investigador i = null;

            List<Investigador> lista = GetInvestigadores();

            foreach (Investigador inv in lista)
            {
                if (inv.Mail == mail)
                {
                    i = inv;
                }
            }

            return i;
        }

        /////////////// MOSTRAR DATOS ///////////////
        public string MostrarCasosYEvidencias()
        {
            string textoConCasos = "";
            foreach (Caso c in _casos)
            {
                textoConCasos += c.ToString();
            }

            //OpcionRegresoInicio();

            return textoConCasos;
        }

        public string MostrarCasosDeUnInvestigador(string mail)
        {
            string textoConCasos = "";

            foreach (Caso c in _casos)
            {
                if(c.InvestigadorD.Mail == mail) 
                    textoConCasos += c.ToString();
            }

            if(textoConCasos == "")
            {
                return $"\n El Investigador no tiene casos asociados. \n";
            }

            return textoConCasos;
        }

        public string MostrarSospechososConAntecedentes()
        {
            string textoConSospechosos = "";

            foreach (Sospechoso s in _sospechosos)
            {
                if (s.TieneAntecedentes)
                {
                    textoConSospechosos += s.ToString();
                    textoConSospechosos += "\n";
                }
            }

            return textoConSospechosos;
        }

        public void ValidarSospechoso(string nombre, string ci, DateTime fechaNac, string antec)
        {
            ValidarNombre(nombre);
            ValidarCi(ci);
            ValidarFecha(fechaNac);
            ValidarAntecedentes(antec);
        }

        private void ValidarAntecedentes(string antec)
        {
            antec = antec.ToUpper();

            if (antec != "S" && antec != "N")
            {
                throw new Exception(" < Ha ocurrido un error / Opcion invalida de Antecedentes > ");
            }
        }

        private void ValidarFecha(DateTime fechaNac)
        {
            DateTime fechaLimite = DateTime.Today.AddYears(-12);

            if (fechaNac > fechaLimite) 
            {
                throw new Exception(" < Ha ocurrido un error / La Fecha de nac. es de un menor de 12 anhos > ");
            }
        }

        public void ValidarNombre(string n)
        {
            if (n.IsWhiteSpace())
            {
                throw new Exception(" < Ha ocurrido un error / El largo del nombre no puede ser nulo. > ");
            }

            if (n.Length > 90)
            {
                throw new Exception(" < Ha ocurrido un error / El largo del nombre no puede superar los 90 caracteres. > ");

            }
        }

        public void ValidarCi(string c)
        {
            if (c.IsWhiteSpace())
            {
                throw new Exception(" < Ha ocurrido un error / El largo de la CI no puede ser nulo. > ");
            }

            if (c.Length > 11)
            {
                throw new Exception(" < Ha ocurrido un error / El largo la CI no puede superar los 11 caracteres. > ");
            }

            if (c.Length < 9)
            {
                throw new Exception(" < Ha ocurrido un error / El largo la CI no puede ser menor a 8 caracteres. > ");
            }
        }

        //sistema
    }
}
