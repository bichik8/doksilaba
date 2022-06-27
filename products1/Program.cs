using System;

namespace products1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Информация о продуктах";

            Console.WriteLine("Программа для вывода информации о продуктах");
            try
            {
                View.Console myConsole = new View.Console("product.bin");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}