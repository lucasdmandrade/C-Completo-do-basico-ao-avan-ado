using System;
using System.Globalization;


namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class LendoDados
    {
        public static void Executar(){
            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual seu salario? ");
            double salario = double.Parse(Console.ReadLine(),
            CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} {salario}");
        }
    }
}