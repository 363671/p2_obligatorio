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
                        case 1:
                            s.OpcionInicial1();
                            Console.WriteLine(s.MostrarCasosYEvidencias());
                            s.OpcionRegresoInicio();
                            break;
                        case 2:
                            s.OpcionInicial2SolicitaCorreo();
                            string mail = Console.ReadLine();
                            
                            if(s.GetInvestigadorPorMail(mail) != null)
                            {
                                s.OpcCorreoDelInvestigadorNoExiste();
                            }
                            else
                            {
                                Console.WriteLine(s.MostrarCasosDeUnInvestigador(mail));
                            }

                            s.OpcionRegresoInicio();
                            break;
                        case 3:
                            s.OpcionInicial3SolicitaNombre();
                            break;
                        case 4:
                            s.OpcionInicial4();
                            s.MostrarSospechososConAntecedentes();
                            break;
                        default:
                            s.OpcionInicial5();
                            break;

                    }
                        

                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    Console.ReadKey();
                }
            }

            // Final de Program
        }
    }
}
