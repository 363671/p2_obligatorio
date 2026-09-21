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
            Investigador i2 = new Investigador("poirot@gmail.com", "Pass1234.", "Hercule Poirot", Rol.Detective);
            Investigador i3 = new Investigador("columbo@gmail.com", "Pass1234.", "Columbo", Rol.Detective);
            Investigador i4 = new Investigador("morgan@gmail.com", "Pass1234.", "Morgan Freeman", Rol.Detective);
            Investigador i5 = new Investigador("watson@gmail.com", "Pass1234.", "John Watson", Rol.Detective);

            Investigador i6 = new Investigador("fiscal1@gmail.com", "Pass1234.", "Carlos Rodriguez", Rol.Fiscal);
            Investigador i7 = new Investigador("fiscal2@gmail.com", "Pass1234.", "Ana Martinez", Rol.Fiscal);
            Investigador i8 = new Investigador("fiscal3@gmail.com", "Pass1234.", "Juan Gonzalez", Rol.Fiscal);
            Investigador i9 = new Investigador("fiscal4@gmail.com", "Pass1234.", "Laura Fernandez", Rol.Fiscal);
            Investigador i10 = new Investigador("fiscal5@gmail.com", "Pass1234.", "Diego Silva", Rol.Fiscal);

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
        }

        private void PrecargarSospechosos()
        {
            Sospechoso s1 = new Sospechoso("Juan Pérez", "11111111-1", new DateTime(1985, 3, 15, 0, 0, 0), true);
            Sospechoso s2 = new Sospechoso("María Gómez", "22222222-2", new DateTime(1990, 7, 22, 0, 0, 0), false);
            Sospechoso s3 = new Sospechoso("Carlos Rodríguez", "33333333-3", new DateTime(1978, 11, 10, 0, 0, 0), true);
            Sospechoso s4 = new Sospechoso("Ana Fernández", "44444444-4", new DateTime(1995, 2, 5, 0, 0, 0), false);
            Sospechoso s5 = new Sospechoso("Luis Martínez", "55555555-5", new DateTime(1988, 9, 18, 0, 0, 0), true);

            Sospechoso s6 = new Sospechoso("Sofía López", "66666666-6", new DateTime(1992, 4, 30, 0, 0, 0), false);
            Sospechoso s7 = new Sospechoso("Pedro Silva", "77777777-7", new DateTime(1983, 12, 12, 0, 0, 0), true);
            Sospechoso s8 = new Sospechoso("Valentina Torres", "88888888-8", new DateTime(1998, 6, 8, 0, 0, 0), false);
            Sospechoso s9 = new Sospechoso("Diego Castro", "99999999-9", new DateTime(1987, 1, 25, 0, 0, 0), true);
            Sospechoso s10 = new Sospechoso("Lucía Ramírez", "10101010-1", new DateTime(1994, 8, 14, 0, 0, 0), false);

            Sospechoso s11 = new Sospechoso("Javier Morales", "12121212-1", new DateTime(1980, 5, 3, 0, 0, 0), true);
            Sospechoso s12 = new Sospechoso("Camila Herrera", "13131313-1", new DateTime(1997, 10, 20, 0, 0, 0), false);
            Sospechoso s13 = new Sospechoso("Fernando Díaz", "14141414-1", new DateTime(1982, 7, 7, 0, 0, 0), true);
            Sospechoso s14 = new Sospechoso("Paula Núñez", "15151515-1", new DateTime(1991, 11, 28, 0, 0, 0), false);
            Sospechoso s15 = new Sospechoso("Ricardo Vega", "16161616-1", new DateTime(1986, 2, 16, 0, 0, 0), true);

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
            Grabacion g1 = new Grabacion(1, true, new DateTime(2024, 1, 15), "Grabacion de una cámara de seguridad frente al lugar del crimen");
            Grabacion g2 = new Grabacion(2, false, new DateTime(2024, 2, 3), "Grabacion de una cámara de seguridad de un supermercado");
            Grabacion g3 = new Grabacion(3, true, new DateTime(2024, 3, 20), "Grabacion donde se observa al sospechoso ingresar al edificio");
            Grabacion g4 = new Grabacion(4, true, new DateTime(2024, 4, 8), "Grabacion de una cámara ubicada en la calle del incidente");
            Grabacion g5 = new Grabacion(1, false, new DateTime(2024, 5, 12), "Grabacion de una cámara de seguridad de una estación de servicio");

            Grabacion g6 = new Grabacion(2, true, new DateTime(2024, 6, 2), "Grabacion de una cámara ubicada en la entrada de un banco");
            Grabacion g7 = new Grabacion(3, false, new DateTime(2024, 6, 18), "Grabacion de una cámara de seguridad de un estacionamiento");
            Grabacion g8 = new Grabacion(4, true, new DateTime(2024, 7, 5), "Grabacion donde se observa una persona abandonar rápidamente la escena");
            Grabacion g9 = new Grabacion(5, true, new DateTime(2024, 7, 21), "Grabacion de una cámara ubicada en un comercio cercano");
            Grabacion g10 = new Grabacion(1, false, new DateTime(2024, 8, 9), "Grabacion de una cámara de seguridad ubicada en una avenida");

            Grabacion g11 = new Grabacion(2, true, new DateTime(2024, 9, 3), "Grabacion de una cámara ubicada frente a una farmacia");
            Grabacion g12 = new Grabacion(3, false, new DateTime(2024, 9, 17), "Grabacion de una cámara ubicada en un supermercado");
            Grabacion g13 = new Grabacion(4, true, new DateTime(2024, 10, 6), "Grabacion donde se observa a una persona acercarse al vehículo de la víctima");
            Grabacion g14 = new Grabacion(5, true, new DateTime(2024, 10, 22), "Grabacion de una cámara ubicada en una plaza cercana");
            Grabacion g15 = new Grabacion(1, false, new DateTime(2024, 11, 8), "Grabacion de una cámara ubicada en la entrada de un edificio");


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
            Fisica f1 = new Fisica(true, new DateTime(2024, 1, 16), "Cuchillo con manchas de sangre encontrado en el lugar");
            Fisica f2 = new Fisica(true, new DateTime(2024, 2, 4), "Huella dactilar encontrada sobre una ventana");
            Fisica f3 = new Fisica(false, new DateTime(2024, 3, 21), "Prenda de ropa encontrada cerca de la escena del crimen");
            Fisica f4 = new Fisica(true, new DateTime(2024, 4, 9), "Casquillo de bala encontrado en el suelo");
            Fisica f5 = new Fisica(false, new DateTime(2024, 5, 13), "Teléfono celular encontrado en las inmediaciones del lugar");

            Fisica f6 = new Fisica(true, new DateTime(2024, 6, 3), "Guante encontrado detrás del edificio");
            Fisica f7 = new Fisica(false, new DateTime(2024, 6, 19), "Mochila encontrada cerca de la escena del crimen");
            Fisica f8 = new Fisica(true, new DateTime(2024, 7, 6), "Herramienta encontrada junto a una puerta forzada");
            Fisica f9 = new Fisica(false, new DateTime(2024, 7, 22), "Documento de identidad encontrado en el lugar");
            Fisica f10 = new Fisica(true, new DateTime(2024, 8, 10), "Llave encontrada en las inmediaciones de la escena");

            Fisica f11 = new Fisica(true, new DateTime(2024, 9, 4), "Huella de calzado encontrada cerca de una ventana");
            Fisica f12 = new Fisica(false, new DateTime(2024, 9, 18), "Gorra encontrada en las inmediaciones del lugar");
            Fisica f13 = new Fisica(true, new DateTime(2024, 10, 7), "Destornillador encontrado junto a una puerta dañada");
            Fisica f14 = new Fisica(false, new DateTime(2024, 10, 23), "Billetera encontrada cerca de la escena del crimen");
            Fisica f15 = new Fisica(true, new DateTime(2024, 11, 9), "Muestra de cabello encontrada en una prenda");

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
            Testimonio t1 = new Testimonio("Homero Simpson", Credibilidad.Bajo, new DateTime(2024, 1, 17), "Afirma haber visto al sospechoso ingresar al lugar del crimen");
            Testimonio t2 = new Testimonio("Marge Simpson", Credibilidad.Medio, new DateTime(2024, 2, 5), "Afirma haber escuchado una discusión cerca del lugar");
            Testimonio t3 = new Testimonio("Bart Simpson", Credibilidad.Alto, new DateTime(2024, 3, 22), "Afirma haber visto un vehículo abandonar la escena");
            Testimonio t4 = new Testimonio("Lisa Simpson", Credibilidad.Alto, new DateTime(2024, 4, 10), "Afirma haber observado al sospechoso durante varios minutos");
            Testimonio t5 = new Testimonio("Ned Flanders", Credibilidad.Medio, new DateTime(2024, 5, 14), "Afirma haber escuchado ruidos provenientes del lugar del crimen");

            Testimonio t6 = new Testimonio("Abraham Simpson", Credibilidad.Bajo, new DateTime(2024, 6, 4), "Afirma haber visto una persona sospechosa cerca del lugar");
            Testimonio t7 = new Testimonio("Milhouse Van Houten", Credibilidad.Medio, new DateTime(2024, 6, 20), "Afirma haber visto un vehículo estacionado durante varias horas");
            Testimonio t8 = new Testimonio("Barney Gumble", Credibilidad.Bajo, new DateTime(2024, 7, 7), "Afirma haber escuchado gritos provenientes del edificio");
            Testimonio t9 = new Testimonio("Edna Krabappel", Credibilidad.Alto, new DateTime(2024, 7, 23), "Afirma haber reconocido al sospechoso en las imágenes");
            Testimonio t10 = new Testimonio("Waylon Smithers", Credibilidad.Alto, new DateTime(2024, 8, 11), "Afirma haber visto al sospechoso salir del lugar del crimen");

            Testimonio t11 = new Testimonio("Moe Szyslak", Credibilidad.Bajo, new DateTime(2024, 9, 5), "Afirma haber visto a una persona salir apresuradamente del lugar");
            Testimonio t12 = new Testimonio("Carl Carlson", Credibilidad.Medio, new DateTime(2024, 9, 19), "Afirma haber observado un vehículo sospechoso estacionado cerca");
            Testimonio t13 = new Testimonio("Lenny Leonard", Credibilidad.Alto, new DateTime(2024, 10, 8), "Afirma haber visto al sospechoso conversando con la víctima");
            Testimonio t14 = new Testimonio("Ralph Wiggum", Credibilidad.Bajo, new DateTime(2024, 10, 24), "Afirma haber escuchado un ruido fuerte durante la noche");
            Testimonio t15 = new Testimonio("Chief Wiggum", Credibilidad.Alto, new DateTime(2024, 11, 10), "Afirma haber identificado al sospechoso mediante las cámaras de seguridad");

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
            Caso c1 = new Caso("Caso Confidencial Indominous Raptor", "Investigación por robo en un comercio del centro.", true, _sospechosos[0], _investigadores[0]);
            Caso c2 = new Caso("Caso Operación Noche Oscura", "Investigación por ingreso no autorizado a una vivienda.", false, _sospechosos[1], _investigadores[1]);
            Caso c3 = new Caso("Caso Misterio del Puerto", "Investigación por desaparición de mercadería en el puerto.", true, _sospechosos[2], _investigadores[2]);
            Caso c4 = new Caso("Caso Código Rojo", "Investigación relacionada con el robo de documentación confidencial.", true, _sospechosos[3], _investigadores[3]);
            Caso c5 = new Caso("Caso Huellas Perdidas", "Investigación por un robo ocurrido durante la madrugada.", false, _sospechosos[4], _investigadores[4]);
            Caso c6 = new Caso("Caso Sombra en la Ciudad", "Investigación por una serie de robos en distintos comercios.", true, _sospechosos[5], _investigadores[5]);
            Caso c7 = new Caso("Caso Última Llamada", "Investigación por la desaparición de un teléfono y documentos personales.", false, _sospechosos[6], _investigadores[6]);
            Caso c8 = new Caso("Caso Puerta Cerrada", "Investigación por ingreso forzado a un depósito.", true, _sospechosos[7], _investigadores[7]);
            Caso c9 = new Caso("Caso Testigo Anónimo", "Investigación iniciada a partir del testimonio de un testigo desconocido.", false, _sospechosos[8], _investigadores[8]);
            Caso c10 = new Caso("Caso Archivo Perdido", "Investigación por la desaparición de documentos de una oficina.", true, _sospechosos[9], _investigadores[0]);

            c1.AgregarEvidencia(_evidencias[0]);
            c1.AgregarEvidencia(_evidencias[1]);
            c1.AgregarEvidencia(_evidencias[2]);
            c1.AgregarEvidencia(_evidencias[30]);

            c2.AgregarEvidencia(_evidencias[3]);
            c2.AgregarEvidencia(_evidencias[4]);
            c2.AgregarEvidencia(_evidencias[5]);
            c2.AgregarEvidencia(_evidencias[31]);

            c3.AgregarEvidencia(_evidencias[6]);
            c3.AgregarEvidencia(_evidencias[7]);
            c3.AgregarEvidencia(_evidencias[8]);
            c3.AgregarEvidencia(_evidencias[32]);

            c4.AgregarEvidencia(_evidencias[9]);
            c4.AgregarEvidencia(_evidencias[10]);
            c4.AgregarEvidencia(_evidencias[11]);
            c4.AgregarEvidencia(_evidencias[33]);

            c5.AgregarEvidencia(_evidencias[12]);
            c5.AgregarEvidencia(_evidencias[13]);
            c5.AgregarEvidencia(_evidencias[14]);
            c5.AgregarEvidencia(_evidencias[34]);

            c6.AgregarEvidencia(_evidencias[15]);
            c6.AgregarEvidencia(_evidencias[16]);
            c6.AgregarEvidencia(_evidencias[17]);
            c6.AgregarEvidencia(_evidencias[35]);

            c7.AgregarEvidencia(_evidencias[18]);
            c7.AgregarEvidencia(_evidencias[19]);
            c7.AgregarEvidencia(_evidencias[20]);
            c7.AgregarEvidencia(_evidencias[36]);

            c8.AgregarEvidencia(_evidencias[21]);
            c8.AgregarEvidencia(_evidencias[22]);
            c8.AgregarEvidencia(_evidencias[23]);
            c8.AgregarEvidencia(_evidencias[37]);

            c9.AgregarEvidencia(_evidencias[24]);
            c9.AgregarEvidencia(_evidencias[25]);
            c9.AgregarEvidencia(_evidencias[26]);
            c9.AgregarEvidencia(_evidencias[38]);

            c10.AgregarEvidencia(_evidencias[27]);
            c10.AgregarEvidencia(_evidencias[28]);
            c10.AgregarEvidencia(_evidencias[29]);
            c10.AgregarEvidencia(_evidencias[39]);

            AgregarCaso(c1);
            AgregarCaso(c2);
            AgregarCaso(c3);
            AgregarCaso(c4);
            AgregarCaso(c5);
            AgregarCaso(c6);
            AgregarCaso(c7);
            AgregarCaso(c8);
            AgregarCaso(c9);
            AgregarCaso(c10);
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

        // // // // // // // // // // // // // // // // //
        //                                              //
        //                  BIENVENIDA                  //
        //                                              //
        // // // // // // // // // // // // // // // // //

        public void Bienvenida()
        {
            string vista = "";

            vista += $"\n |             Obligatorio 1 - P2              |";
            vista += $"\n              Sistema de Fiscalía";
            vista += $"\n                  Diego Weble";
            vista += $"\n                      N2A \n";
            vista += $"\n <       Presiona una tecla para empezar      > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // // // //
        //                                              //
        //                MENÚ INICIAL                  //
        //                                              //
        // // // // // // // // // // // // // // // // //

        public void MenuInicial()
        {
            string vista = "";

            vista += $"\n |               Obligatorio 1 - P2               |";
            vista += $"\n               > Sistema de Fiscalía <";
            vista += $"\n   Selecciona una de las opciones disponibles:\n ";
            vista += $"\n     1 - Listado de Casos y sus Evidencias";
            vista += $"\n     2 - Casos de un Investigador";
            vista += $"\n     3 - Alta de un Sospechoso";
            vista += $"\n     4 - Listado de Sospechosos con Antecedentes";
            vista += $"\n     5 - Salir \n";
            vista += $"\n       < Ingresa un número y luego ENTER: > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // // // //
        // Opcion 1 - Listado de Casos y sus Evidencias //
        // // // // // // // // // // // // // // // // //

        public void OpcionInicial1()
        {
            string vista = "";

            vista += $"\n <               Elegiste               >";
            vista += $"\n 1 - Listado de Casos y sus Evidencias \n";
            
            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // // // //
        // Opcion 4 - Listado de Sospechosos con Antecedentes //
        // // // // // // // // // // // // // // // // //
        public void OpcionInicial4()
        {
            string vista = "";
            
            vista += $"\n <                  Elegiste                  >";
            vista += $"\n 4 - Listado de Sospechosos con Antecedentes \n";
            
            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // // // //
        //        Opcion Home - Regresar al Inicio      //
        // // // // // // // // // // // // // // // // //
        public void OpcionRegresoInicio()
        {
            string vista = "";

            vista += $"\n <  Presiona una tecla para volver  > \n";

            Console.WriteLine(vista);
            Console.ReadKey();
        }

        // // // // // // // // // // // // // // // // // // // // // // // // // // // //

        //                    Opcion 2 - Casos de un Investigador

        // // // // // // // // // // // // // // // // // // // // // // // // // // // // 

        public void OpcionInicial2SolicitaCorreo()
        {
            string vista = "";

            vista += $"\n <                Elegiste                >";
            vista += $"\n       2 - Casos de un Investigador \n";
            vista += $"\n <   Ingresa el Correo del Investigador:  > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // //
        // Opcion 2.1 - Casos de un Investigador //
        // // // // // // // // // // // // // // //

        public void Opcion2ListadoDeInvestigador(string mail)
        {
            string vista = "";

            vista += $"\n <                     Elegiste                     >";
            vista += $"\n       2 - Casos de un Investigador \n";
            vista += $"\n < Ingresaste el CORREO {mail} del Investigador: > \n";
            vista += $"\n \n";

            // listado de CASOS del INVESTIGADOR

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // //
        // Opcion 2.1.1 - No se encontró un Investigador con dicho correo //
        // // // // // // // // // // // // // // //

        public void OpcCorreoDelInvestigadorNoExiste()
        {
            string vista = "";

            vista += $"\n <                     Elegiste                     >";
            vista += $"\n       2 - Casos de un Investigador \n";
            vista += $"\n <      Ingresaste el Correo del Investigador:      > \n\n";
            vista += $"\n <   No hay Investigador asociado a dicho correo:   > \n";
            vista += $"\n \n";
            vista += $"\n <      Presiona ENTER para ingresar otro mail      > \n";
            vista += $"\n <        Presiona ESC para volver al Inicio        > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }


        // // // // // // // // // // // // // // // // // // // // // // // // // // // //

        //         Opcion 3 - Alta de un Sospechoso - se pide el Nombre Completo

        // // // // // // // // // // // // // // // // // // // // // // // // // // // // 

        public void OpcionInicial3SolicitaNombre()
        {
            string vista = "";

            vista += $"\n <             Elegiste           >";
            vista += $"\n   3 - Alta de un Sospechoso \n";
            vista += $"\n <   Ingresa el Nombre Completo:  > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        public void OpcionInicial3NombreInvalido()
        {
            string vista = "";

            vista += $"\n <                  Elegiste                  >";
            vista += $"\n   3 - Alta de un Sospechoso \n";
            vista += $"\n <      Ingresaste un NOMBRE invalido > \n     ";
            vista += $"\n";
            vista += $"\n <   Presiona ENTER para ingresar un NOMBRE   > \n";
            vista += $"\n <     Presiona ESC para volver al Inicio     > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // // // // //
        // Opcion 3 - Alta de un Sospechoso - se pide la CI
        // // // // // // // // // // // // // // // // // //
        public void OpcionInicial3SolicitaCI()
        {
            string vista = "";

            vista += $"\n <          Elegiste          >";
            vista += $"\n   3 - Alta de un Sospechoso \n";
            vista += $"\n <     Ingresa la Cedula:     > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // //
        // Opcion 3 - Alta de un Sospechoso - CI invalida
        // // // // // // // // // // // // //
        public void OpcionInicial3CIInvalida()
        {
            string vista = "";

            vista += $"\n <            Elegiste             >";
            vista += $"\n    3 - Alta de un Sospechoso \n";
            vista += $"\n < Ingresaste una Cedula Inválida: > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // //
        // Opcion 3 - Alta de un Sospechoso - se pide la FECHA de NAC.
        // // // // // // // // // // // // //
        public void OpcionInicial3SolicitaFechaDeNac()
        {
            string vista = "";

            vista += $"\n <                      Elegiste                      >";
            vista += $"\n               3 - Alta de un Sospechoso \n";
            vista += $"\n < Ingresa la Fecha de Nacimiento: FORMATO AAAA/MM/DD > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // // // // // // // // 
        // Opcion 3 - Alta de un Sospechoso - se pide la FECHA de NAC.
        // // // // // // // // // // // // // // // // // // // // //
        public void OpcionInicial3FechaNacInvalida()
        {
            string vista = "";

            vista += $"\n <                 Elegiste                >";
            vista += $"\n         3 - Alta de un Sospechoso \n";
            vista += $"\n <  Ingresaste una FECHA de NAC. invalida: > \n";
            vista += $"\n ";
            vista += $"\n < Presiona ENTER para ingresar otra FECHA > \n";
            vista += $"\n < Presiona ESC para volver al Inicio > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // // // // // // // // // // // // //
        // Opcion 3 - Alta de un Sospechoso - se pide si tiene Antecedentes
        // // // // // // // // // // // // // // // // // // // // // // //
        public void Opcion3SolicitaAntecedentes()
        {
            string vista = "";

            vista += $"\n <                 Elegiste              >";
            vista += $"\n         3 - Alta de un Sospechoso      \n";
            vista += $"\n <    Ingresa S si tiene Antecedentes    > \n";
            vista += $" <   Ingresa N si no tiene Antecedentes  > \n";
            vista += $"\n <   Presiona ESC para volver al Inicio  > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // //
        // Opcion 3 - Alta de un Sospechoso - Antecedentes invalido
        // // // // // // // // // // // // //
        public void OpcionInicial3AntecedentesInvalidos()
        {
            string vista = "";

            vista += $"\n <                          Elegiste                          >";
            vista += $"\n                  3 - Alta de un Sospechoso \n";
            vista += $"\n <               Ingresaste una opcion invalida               > \n";
            vista += $"\n";
            vista += $"\n <   Presiona ENTER para ingresar si tiene o no Antecedentes  > \n";
            vista += $"\n <              Presiona ESC para volver al Inicio            > \n";
            
            Console.Clear();
            Console.WriteLine(vista);
        }

        // // // // // // // // // // // //
        // Op3AltaExitosa
        // // // // // // // // // // // // //
        public void Op3AltaExitosa()
        {
            string vista = "";

            vista += $"\n <                Elegiste                >";
            vista += $"\n         3 - Alta de un Sospechoso \n";
            vista += $"\n <         ¡Sospechoso ingresado!         > \n";
            vista += $"\n ";
            vista += $"\n <  Presiona ENTER para volver al Inicio  > \n";

            Console.Clear();
            Console.WriteLine(vista);
        }

        public void OpcionInicial5()
        {
            string vista = "";

            vista += $"\n <   Elegiste una opcion invalida    >";
            vista += $"\n < Presiona esc para elegir otra vez >";

            Console.WriteLine(vista);
        }


        //sistema
    }
}
