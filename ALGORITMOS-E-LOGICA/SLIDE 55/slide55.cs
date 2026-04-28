using System;

namespace SIPeriodo1.AlgoritmosELogica.Slide55 {
    class Slide55 {
        //Este exemplo é o mesmo do slide 54, mas já declarando o valor das variáveis na mesma linha da declaração.
        public static void Main (string[] args) {
            int idade = 23;
            double altura = 1.76, peso = 78.9;
            string nome = "João da Silva";
            bool temCNH = true;
            double copiaPeso = peso;
            double IMC = peso / (altura * altura);

            Console.WriteLine($"Nome: {nome}, Idade: {idade}, CNH: {temCNH}");
            Console.WriteLine($"IMC calculado: {IMC:F2}");
            }    
    }    
}