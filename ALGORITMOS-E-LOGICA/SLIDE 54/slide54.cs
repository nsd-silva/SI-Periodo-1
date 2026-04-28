using System;

namespace SIPeriodo1.AlgoritmosELogica.Slide54 {
    class Slide54 {
        //Neste exemplo é só um exemplo de atribuição de valores às variáveis, e também o cálculo do IMC.
        public static void Main (string[] args) {
            int idade;
            double altura, peso, copiaPeso, IMC;
            string nome;
            bool temCNH;
            idade = 23;
            altura = 1.76;
            peso = 78.9;
            nome = "João da Silva";
            temCNH = true;
            copiaPeso = peso;
            IMC = peso / (altura * altura);
        
            Console.WriteLine($"Nome: {nome}, Idade: {idade}, CNH: {temCNH}");
            Console.WriteLine($"IMC calculado: {IMC:F2}");
        }
    }
}