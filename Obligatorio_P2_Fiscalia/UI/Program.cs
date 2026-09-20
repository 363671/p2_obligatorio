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

            s.Bienvenida();
            Console.ReadKey();

            while (!eligioSalir)
            {
                try
                {
                    s.MenuInicial();
                    int eleccion = int.Parse(Console.ReadLine());

                    switch (eleccion)
                    {
                        //CASO 1
                        case 1:
                            s.OpcionInicial1();
                            Console.WriteLine(s.MostrarCasosYEvidencias());
                            s.OpcionRegresoInicio();
                            break;

                        //CASO 2
                        case 2:
                            s.OpcionInicial2SolicitaCorreo();
                            string mail = Console.ReadLine();

                            if (s.GetInvestigadorPorMail(mail) != null)
                            {
                                Console.WriteLine(s.MostrarCasosDeUnInvestigador(mail));
                            }
                            else
                            {
                                s.OpcCorreoDelInvestigadorNoExiste();
                            }

                            s.OpcionRegresoInicio();
                            break;

                        //CASO 3
                        case 3:
                            s.OpcionInicial3SolicitaNombre();
                            string nombre = Console.ReadLine();

                            s.OpcionInicial3SolicitaCI();
                            string ci = Console.ReadLine();

                            s.OpcionInicial3SolicitaFechaDeNac();
                            DateTime fechaNac = DateTime.Parse(Console.ReadLine());

                            s.ValidarSospechoso(nombre, ci, fechaNac);
                            break;

                        //CASO 4
                        case 4:
                            s.OpcionInicial4();
                            s.MostrarSospechososConAntecedentes();
                            break;

                        //CASO 5
                        case 5:
                            eligioSalir = true;
                            break;
                        default:
                            s.OpcionInicial5();
                            break;

                    }
                        

                    Console.ReadKey();
                }
                
                catch (FormatException)
                {
                    Console.WriteLine(" \n ----------------- ERROR -----------------");
                    Console.WriteLine(" El formato que introduciste no es válido. \n Asegúrate de ingresarlo acorde a lo indicado.");
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                }

                Console.ReadKey();
            }

            // Final de Program
        }
    }
}
