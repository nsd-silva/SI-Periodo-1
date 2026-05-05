using System;

namespace SIPeriodo1.AlgoritmosELogica.Slide77
{
    class Slide77
    {
        public static void Main(string[] args)
        {
            int preinc = 7, posinc = 7, predec = 7, posdec = 7;
            Console.WriteLine($"preinc = {++preinc}"); //aqui ele incrementa o valor antes de imprimir
            Console.WriteLine($"posinc = {posinc++}"); //aqui ele imprime o valor e depois incrementa
            Console.WriteLine($"predec = {--predec}"); //aqui ele decrementa o valor antes de imprimir
            Console.WriteLine($"posdec = {posdec--}"); //aqui ele imprime o valor e depois decrementa
            Console.WriteLine("\nREIMPRIMINDO");
            Console.WriteLine($"preinc = {preinc}"); //aqui ele imprime o valor atualizado do preinc
            Console.WriteLine($"posinc = {posinc}"); //aqui ele imprime o valor atualizado do posinc
            Console.WriteLine($"predec = {predec}"); //aqui ele imprime o valor atualizado do predec
            Console.WriteLine($"posdec = {posdec}"); //aqui ele imprime o valor atualizado do posdec
        }
    }
}  