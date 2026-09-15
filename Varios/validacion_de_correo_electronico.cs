using System.Collections;

namespace Practico1_Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            10. Solicitar al usuario un texto e indicar si tiene formato de email. Un email es válido si:
                a. Contiene un largo mayor a 1
                b. Contiene arroba y este no se encuentra en primera o última posición
                c. Contiene al menos 1 punto y este no se encuentra en primera o última posición.
            */
            
            try
            {
                while (true) {
                    Console.Clear();
                    Console.WriteLine(" < Practico 1 Ejercicio 10 > ");
                    Console.WriteLine();
                    Console.WriteLine(" Introduzca su CORREO ELECTRONICO: ");
                    Console.WriteLine();
                    String mailUsuario = Console.ReadLine();
                
                    char primerCaracter = mailUsuario[0];
                    char ultimoCaracter = mailUsuario[mailUsuario.Length - 1];
                    char arroba = '@';

                    String errores = "";
                    if (primerCaracter == arroba)
                    {
                        errores += "El primer carácter no puede ser un @. ";
                    }

                    if (ultimoCaracter == arroba)
                    {
                        errores += "El último carácter no puede ser un @. ";
                    }

                    if (primerCaracter == '.')
                    {
                        errores += "El primer carácter no puede ser un punto. ";
                    }

                    if (ultimoCaracter == '.')
                    {
                        errores += "El último carácter no puede ser un punto. ";
                    }

                    if (mailUsuario.Length <= 1)
                    {
                        errores += "El largo del correo debe ser mayor a 1. ";
                    }

                    if (!mailUsuario.Contains("@"))
                    {
                        errores += "El correo no tiene @. ";
                    }

                    if (!mailUsuario.Contains("."))
                    {
                        errores += "El correo no tiene punto. ";
                    }

                    if (errores == "")
                    {
                        Console.WriteLine("");
                        Console.WriteLine($" {mailUsuario} ");
                        Console.WriteLine("");
                        Console.WriteLine(" El formato de tu correo es CORRECTO. ");
                    }
                    else
                    {
                        Console.WriteLine(errores);
                    }
                        Console.WriteLine("");
                        Console.WriteLine(" < Presione cualquier tecla. > ");
                        Console.WriteLine("");
                        Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" < Ha ocurrido un ERROR > ");
                Console.WriteLine("");
            }
        }
    }
}
