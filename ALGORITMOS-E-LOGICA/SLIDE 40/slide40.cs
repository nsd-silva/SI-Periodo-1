using System;

namespace SIPeriodo1.AlgoritmosELogica.Slide40 {
    class Slide40 {
        static void Main(string[] args) {

            int a, b, c;
            Console.Write("Digite o número para o fatorial: "); //Isso foi adicionado para o usuário saber o que deve ser digitado, já que o programa não tem interface gráfica.
            a = int.Parse(Console.ReadLine() ?? "0");
            b = 1;

            for (c = 2; c <= a; c++) {
                b = b * c;
            }

            Console.Write(b);
            Console.ReadKey(); //Após isso aqui o programa já estava funcionando, mas como o exemplo do professor não retornava nada, eu adicionei o comentário na linha 7. 

        }
    }
}