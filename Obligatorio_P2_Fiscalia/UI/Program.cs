using Dominio;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Inicio de Program
            Sistema s = Sistema.GetInstancia();

            bool eligioSalir = false;


            DataToUser.Bienvenida();
            Console.ReadKey();

            while (!eligioSalir)
            {
                try
                {
                    DataToUser.MenuInicial();

                    int eleccion = int.Parse(Console.ReadLine());

                    switch (eleccion)
                    {
                        // // // // CASO 1 // // // // 
                        case 1:
                            DataToUser.OpcionInicial1();
                            Console.WriteLine(s.MostrarCasosYEvidencias());
                            break;

                        // // // // CASO 2 // // // // 
                        case 2:
                            DataToUser.OpcionInicial2SolicitaCorreo();
                            string mail = Console.ReadLine();

                            if (s.GetInvestigadorPorMail(mail) != null)
                            {
                                Console.WriteLine(s.MostrarCasosDeUnInvestigador(mail));
                            }
                            else
                            {
                                DataToUser.OpcCorreoDelInvestigadorNoExiste();
                            }

                            DataToUser.OpcionRegresoInicio();
                            break;

                        // // // // CASO 3 // // // // 
                        case 3:
                            DataToUser.OpcionInicial3SolicitaNombre();
                            string nombre = Console.ReadLine();

                            DataToUser.OpcionInicial3SolicitaCI();
                            Console.WriteLine($" Llevas 1/4 datos -> Nombre: {nombre} \n");
                            string ci = Console.ReadLine();

                            DataToUser.OpcionInicial3SolicitaFechaDeNac();
                            Console.WriteLine($" Llevas 2/4 datos -> Nombre: {nombre} / CI: {ci} \n");

                            DateTime fechaNac = DateTime.Parse(Console.ReadLine());

                            DataToUser.Opcion3SolicitaAntecedentes();
                            Console.WriteLine($" Llevas 3/4 datos -> Nombre: {nombre} / CI: {ci} / Fecha Nac.: {fechaNac}\n");

                            string antecedentes = Console.ReadLine();
                            Console.WriteLine($" Llevas 4/4 datos -> Nombre: {nombre} / CI: {ci} / Fecha Nac.: {fechaNac} / Antecedentes: {antecedentes} \n");

                            s.ValidarSospechoso(nombre, ci, fechaNac, antecedentes);
                            s.AltaSospechoso(nombre, ci, fechaNac, antecedentes);
                            DataToUser.Op3AltaExitosa();
                            break;

                        // // // // CASO 4 // // // // 
                        case 4:
                            DataToUser.OpcionInicial4();
                            Console.WriteLine(s.MostrarSospechososConAntecedentes());
                            break;

                        // // // // CASO 5 // // // //
                        case 5:
                            eligioSalir = true;
                            break;

                        // // // // CASO DEFAULT // // // // 
                        default:
                            DataToUser.OpcionInicial5();
                            break;

                    }

                    Console.ReadKey();
                }

                // // // // catches de errores // // // // 
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" \n ------------------- ERROR ------------------- ");
                    Console.WriteLine(" El formato que introduciste no es válido. \n Asegúrate de ingresarlo acorde a lo indicado.");
                    Console.WriteLine(" \n ----------- ENTER para reintentar ----------- ");
                    Console.ResetColor();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {e.Message}");
                    Console.ResetColor();
                    Console.WriteLine("Por favor, intente de nuevo.\n");
                }

                Console.ReadKey();
            }

            // Final de Program
        }

        public static class DataToUser
        {

            // // // // // // // // // // // // // // // // //
            //                                              //
            //                  BIENVENIDA                  //
            //                                              //
            // // // // // // // // // // // // // // // // //

            public static void Bienvenida()
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

            public static void MenuInicial()
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

            public static void OpcionInicial1()
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
            public static void OpcionInicial4()
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
            public static void OpcionRegresoInicio()
            {
                string vista = "";

                vista += $"\n <  Presiona una tecla para volver  > \n";

                Console.WriteLine(vista);
            }

            // // // // // // // // // // // // // // // // // // // // // // // // // // // //

            //                    Opcion 2 - Casos de un Investigador

            // // // // // // // // // // // // // // // // // // // // // // // // // // // // 

            public static void OpcionInicial2SolicitaCorreo()
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

            public static void Opcion2ListadoDeInvestigador(string mail)
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

            public static void OpcCorreoDelInvestigadorNoExiste()
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

            public static void OpcionInicial3SolicitaNombre()
            {
                string vista = "";

                vista += $"\n <             Elegiste           >";
                vista += $"\n   3 - Alta de un Sospechoso \n";
                vista += $"\n <   Ingresa el Nombre Completo:  > \n";

                Console.Clear();
                Console.WriteLine(vista);
            }

            public static void OpcionInicial3NombreInvalido()
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
            public static void OpcionInicial3SolicitaCI()
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
            public static void OpcionInicial3CIInvalida()
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
            public static void OpcionInicial3SolicitaFechaDeNac()
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
            public static void OpcionInicial3FechaNacInvalida()
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
            public static void Opcion3SolicitaAntecedentes()
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
            public static void OpcionInicial3AntecedentesInvalidos()
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
            public static void Op3AltaExitosa()
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

            public static void OpcionInicial5()
            {
                string vista = "";

                vista += $"\n <   Elegiste una opcion invalida    >";
                vista += $"\n < Presiona esc para elegir otra vez >";

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(vista);
                Console.ResetColor();
            }
        }
    }
}
