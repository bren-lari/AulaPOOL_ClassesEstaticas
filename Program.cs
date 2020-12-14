using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- Programa de conversões de valores ---\r\n");

            Console.WriteLine(Conversor.CoverterDolarParaReal(540));
            Console.WriteLine(Conversor.DolarParaReais(995));

            Console.ResetColor();
            Console.WriteLine("------------\r\n");
            Console.WriteLine(" -> Conversão de EURO para REAL");

            Console.WriteLine(Converter.ConversãoDoEuroParaReal(333));
            Console.WriteLine(Converter.EuroParaReal(13));



    }

}
}
