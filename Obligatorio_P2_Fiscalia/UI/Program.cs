using Dominio;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicio de Program
            try
            {

            

                Console.WriteLine(" < > ");

                string test = "qwer@gmail.";

                Console.WriteLine();
                Console.WriteLine(test);
                Console.WriteLine();
                Console.WriteLine(test.First());
                Console.WriteLine();
                Console.WriteLine(test.Last());

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
                Console.WriteLine();
            }

            // Final de Program
        }
    }
}
