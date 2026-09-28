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
                    Console.Clear();
                    DataToUser.MenuInicial();

                    int eleccion = int.Parse(Console.ReadLine());

                    switch (eleccion)
                    {
                        // // // // CASO 1 // // // // 
                        case 1:
                            DataToUser.OpcionInicial1();
                            s.MostrarCasosYEvidencias();
                            DataToUser.OpcionRegresoInicio();
                            break;

                        // // // // CASO 2 // // // // 
                        case 2:
                            DataToUser.OpcionInicial2SolicitaCorreo();
                            string mail = Console.ReadLine();

                            if (s.GetInvestigadorPorMail(mail) != null)
                            {
                                DataToUser.Opcion2ListadoDeInvestigador(mail);
                                s.MostrarCasosDeUnInvestigador(mail);
                            } else {
                                DataToUser.OpcCorreoDelInvestigadorNoExiste(mail);
                            }

                            DataToUser.OpcionRegresoInicio();
                            break;

                        // // // // CASO 3 // // // //
                        case 3:
                            // Se solicitan los datos del sospechoso
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
                            
                            // Se validan los datos del sospechoso
                            s.ValidarSospechoso(nombre, ci, fechaNac, antecedentes);

                            // Si la validacion de antes no arroja ninguna Exception, se crea el Sospechoso
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
                            // Se cambia la Bandera para finalizar el While
                            eligioSalir = true;
                            break;

                        // // // // CASO DEFAULT // // // // 
                        default:
                            DataToUser.OpcionInicial5();
                            break;
                    }

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
                    Console.WriteLine("\n\n Por favor, intente de nuevo. \n");
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

                vista += $"\n |              Obligatorio 1 - P2              |";
                vista += $"\n              Sistema de Fiscalía";
                vista += $"\n                  Diego Weble";
                vista += $"\n                      N2A \n";
                vista += $"\n  <       Presiona una tecla para empezar      > \n";

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
                Console.Clear();

                Console.WriteLine($"\n |                Obligatorio 1 - P2               |");
                Console.WriteLine($"               > Sistema de Fiscalía <");
                Console.WriteLine($"     Selecciona una de las opciones disponibles:\n ");
                
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine($"      1 - Listado de Casos y sus Evidencias");
                Console.WriteLine($"      2 - Casos de un Investigador");
                Console.WriteLine($"      3 - Alta de un Sospechoso");
                Console.WriteLine($"      4 - Listado de Sospechosos con Antecedentes");
                Console.WriteLine($"      5 - Salir ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine($"\n        < Ingresa un número y luego ENTER: > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // //
            // Opcion 1 - Listado de Casos y sus Evidencias
            // // // // // // // // // // // // // // // //

            public static void OpcionInicial1()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <               Elegiste               >");
                Console.WriteLine($"  1 - Listado de Casos y sus Evidencias");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // // // // //
            // Opcion 4 - Listado de Sospechosos con Antecedentes
            // // // // // // // // // // // // // // // // // // //
            public static void OpcionInicial4()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <                  Elegiste                  >");
                Console.WriteLine($"\n 4 - Listado de Sospechosos con Antecedentes \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // //
            // Opcion Home - Regresar al Inicio
            // // // // // // // // // // // //

            public static void OpcionRegresoInicio()
            {
                string vista = "";

                vista += $" <  Presiona una tecla para volver  > \n";

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine(vista);

                Console.ResetColor();
            }

            // // // // // // // // // // // // //
            // Opcion 2 - Casos de un Investigador
            // // // // // // // // // // // // //

            public static void OpcionInicial2SolicitaCorreo()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <                Elegiste                >");
                Console.WriteLine($"       2 - Casos de un Investigador ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n <   Ingresa el Correo del Investigador:  > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // //
            // Opcion 2.1 - Casos de un Investigador
            // // // // // // // // // // // // // //

            public static void Opcion2ListadoDeInvestigador(string mail)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <                Elegiste                >");
                Console.WriteLine($"        2 - Casos de un Investigador \n");
                Console.Write($" < Ingresaste el CORREO ");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write($"{ mail}");


                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($" >");

                Console.ResetColor();

                // listado de CASOS del INVESTIGADOR
            }

            // // // // // // // // // // // // // // // // // // // // // //
            // Opcion 2.1.1 - No se encontró un Investigador con dicho correo
            // // // // // // // // // // // // // // // // // // // // // //

            public static void OpcCorreoDelInvestigadorNoExiste(string mail)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <                     Elegiste                     >");
                Console.WriteLine($"        2 - Casos de un Investigador \n");

                Console.ResetColor();
                Console.WriteLine($" <   Ingresaste el CORREO {mail} del Investigador:  > ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" <   No hay Investigador asociado a dicho correo:   > ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" <      Presiona ENTER para ingresar otro mail      > ");
                Console.WriteLine($" <        Presiona ESC para volver al Inicio        > \n");
                
                Console.ResetColor();
            }


            // // // // // // // // // // // // // // // // // // // // // //
            // Opcion 3 - Alta de un Sospechoso - se pide el Nombre Completo
            // // // // // // // // // // // // // // // // // // // // // //

            public static void OpcionInicial3SolicitaNombre()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <             Elegiste           >");
                Console.WriteLine($"\n   3 - Alta de un Sospechoso \n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine($"\n <   Ingresa el Nombre Completo:  > \n");
             
                Console.ResetColor();
            }

            public static void OpcionInicial3NombreInvalido()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <                  Elegiste                  >");
                Console.WriteLine($"\n           3 - Alta de un Sospechoso \n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n        < Ingresaste un NOMBRE invalido > \n     ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n <   Presiona ENTER para ingresar un NOMBRE   > \n");
                Console.WriteLine($"\n <     Presiona ESC para volver al Inicio     > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // // // //
            // Opcion 3 - Alta de un Sospechoso - se pide la CI
            // // // // // // // // // // // // // // // // // //
            public static void OpcionInicial3SolicitaCI()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <          Elegiste          >");
                Console.WriteLine($"\n   3 - Alta de un Sospechoso \n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n <     Ingresa la Cedula:     > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // // //
            // Opcion 3 - Alta de un Sospechoso - CI invalida
            // // // // // // // // // // // // // // // // //
            public static void OpcionInicial3CIInvalida()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <          Elegiste          >");
                Console.WriteLine($"\n   3 - Alta de un Sospechoso \n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n < Ingresaste una Cedula Inválida: > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // // // // // // //
            // Opcion 3 - Alta de un Sospechoso - se pide la FECHA de NAC.
            // // // // // // // // // // // // // // // // // // // // //
            public static void OpcionInicial3SolicitaFechaDeNac()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n <                      Elegiste                      >");
                Console.WriteLine($"              3 - Alta de un Sospechoso ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n < Ingresa la Fecha de Nacimiento: FORMATO AAAA/MM/DD > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // // // // // // // 
            // Opcion 3 - Alta de un Sospechoso - se pide la FECHA de NAC.
            // // // // // // // // // // // // // // // // // // // // //
            public static void OpcionInicial3FechaNacInvalida()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n <                 Elegiste                >");
                Console.WriteLine($"\n         3 - Alta de un Sospechoso \n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n <  Ingresaste una FECHA de NAC. invalida: > \n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n < Presiona ENTER para ingresar otra FECHA > \n");
                Console.WriteLine($"\n   < Presiona ESC para volver al Inicio > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // // // // // // // // //
            // Opcion 3 - Alta de un Sospechoso - se pide si tiene Antecedentes
            // // // // // // // // // // // // // // // // // // // // // // //
            public static void Opcion3SolicitaAntecedentes()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n <                 Elegiste              >");
                Console.WriteLine($"         3 - Alta de un Sospechoso      ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n <    Ingresa S si tiene Antecedentes    > ");
                Console.WriteLine($" <   Ingresa N si no tiene Antecedentes  > \n");

                Console.WriteLine($" <   Presiona ESC para volver al Inicio  > \n");

                Console.ResetColor();
            }

            // // // // // // // // // // // // // // // // // // // //
            // Opcion 3 - Alta de un Sospechoso - Antecedentes invalido
            // // // // // // // // // // // // // // // // // // // //

            public static void OpcionInicial3AntecedentesInvalidos()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n < Elegiste >");
                Console.WriteLine($" 3 - Alta de un Sospechoso ");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n < Ingresaste una opcion invalida > \n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($" < Presiona ENTER para ingresar si tiene o no Antecedentes > ");
                Console.WriteLine($" < Presiona ESC para volver al Inicio > \n");

                Console.ResetColor();
            }

            // // // // // //
            // Op3AltaExitosa
            // // // // // //

            public static void Op3AltaExitosa()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n <                 Elegiste                 >");
                Console.WriteLine($"         3 - Alta de un Sospechoso \n");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($" <          ¡Sospechoso ingresado!          > \n");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"n <   Presiona ENTER para volver al Inicio   > \n");

                Console.ResetColor();
            }

            public static void OpcionInicial5()
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n <   Elegiste una opcion invalida    >");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"\n < Presiona ESC para elegir otra vez >");

                Console.ResetColor();
            }
        }
    }
}
