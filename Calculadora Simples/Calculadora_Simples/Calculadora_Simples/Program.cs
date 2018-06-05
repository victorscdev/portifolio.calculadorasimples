using System;


namespace Aula0010_Mini_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aprendendo a fazer um calculadora simples

            double d;
            //d = 12 + 3;//soma
            //d = 12 - 3;//subtração
            //d = 12 * 3;//multiplicação (x)
            //d = 12 / 3;//divisão (/)
            //Console.WriteLine(d);

            double num1, num2;
            string tmp;

            Console.WriteLine("Digite um numero: ");
            tmp = Console.ReadLine();
            num1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um numero: ");
            tmp = Console.ReadLine();
            num2 = int.Parse(tmp);

            double resultado;
            resultado = num1 + num2;
            Console.WriteLine("Soma: " + resultado);

            resultado = num1 - num2;
            Console.WriteLine("Subtração: " + resultado);

            resultado = num1 * num2;
            Console.WriteLine("Multiplicação: " + resultado);

            resultado = num1 / num2;
            Console.WriteLine("Divisão: " + resultado);

            Console.ReadKey();