using System;

namespace SIPeriodo1.AlgoritmosELogica.Slide61{
    class Slide61 {
        //Este exercício tem o objetivo de mostrar as três formas de exibir uma mensagem no console utilizando as variáveis nome e idade.
        public static void Main (string[] args) {
            int idade = 27;
            string nome = "João da Silva";
            // Concatenação
            Console.WriteLine("Meu nome é "+nome+" e tenho "+idade+" anos de idade.");
            // Placeholder
            Console.WriteLine("Meu nome é {0} e tenho {1} anos de idade.", nome, idade);
            // Interpolação
            Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos de idade.");
            Console.ReadKey();
        }
    }
}