//Nome: João Herval Maia
//Data: 11/09/2021
//Exercicio 4: recebendo 4 números inteiros e calculando a soma deles
using System;

namespace lista1_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarando as variáveis dos 4 números e da soma
            int num1, num2, num3, num4, soma;
            Console.WriteLine("Qual são os números desejados");
            // dando valor às variáveis dos 4 números 
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());
            num4 = int.Parse(Console.ReadLine());
            //fazendo a soma dos números e dando valor à variável da soma
            soma = num1 + num2 + num3 + num4;
            //imprimindo a soma dos 4 números
            Console.WriteLine("A soma dos números é igual a "+soma);
        }
    }
}
