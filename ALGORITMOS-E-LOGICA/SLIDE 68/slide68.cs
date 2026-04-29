using System;

namespace SIPeriodo1.AlgoritmosELogica.Slide68{
    class Slide68 {
        //Este exemplo tem a finalidade de mostrar diferentes comandos de entrada de dados. 
        public static void Main (string[] args) {
            int n1, n2;
            double n3, n4;
            float n5;
            string s;
            bool b1;
            // Leitura de Inteiros
            Console.Write("Digite um número inteiro: ");
            n1 = int.Parse(Console.ReadLine()!); 
            Console.Write("Digite outro número inteiro: ");
            n2 = Convert.ToInt32(Console.ReadLine()!);
            // Leitura de valores ponto-flutuante //Obs.: Ponto flutuante nada mais é que um número com casa decimal.
            Console.Write("Digite um número real: ");
            n3 = double.Parse(Console.ReadLine()!);
            Console.Write("Digite outro número real: ");
            n4 = Convert.ToDouble(Console.ReadLine()!);
            Console.Write("Digite mais um número real: ");
            n5 = float.Parse(Console.ReadLine()!);
            //Obs. 2: A diferença entre double e float é que o double tem uma precisão maior, ou seja, ele pode armazenar mais casas decimais do que o float. Em compensação ele é mais lento e pesado que o float. 
            Console.Write("Digite qualquer coisa, afinal é uma string: ");
            s = Console.ReadLine()!;
            Console.Write("Digite um booleano (digite true ou false): ");
            b1 = bool.Parse(Console.ReadLine()!);
            Console.ReadKey();
        }
    }
}