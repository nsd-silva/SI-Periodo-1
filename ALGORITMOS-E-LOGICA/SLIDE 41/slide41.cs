using System;

namespace SIPeriodo1.AlgoritmosELogica.Slide41 {
    class Slide41 {
        static void Main(string[] args) {
            int Numero, Fatorial, Contador;
            Console.Write("Informe um número: ");
            Numero = int.Parse(Console.ReadLine() ?? "0");
            Fatorial = 1;
            for (Contador = 2; Contador <= Numero; Contador++)
            Fatorial = Fatorial * Contador;
            Console.Write("Fatorial de "+Numero+" = "+ Fatorial);
            Console.ReadKey();
        }
    }
}
// Esse código faz a exata mesma coisa que o slide 40, só foram realizadas algumas mudanças para dar nomes significativos as variáveis deixano mais fácil de compreender.