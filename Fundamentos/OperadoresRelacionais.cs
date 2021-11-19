using System;

namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class OperadoresRelacionais
    {
        public static void Executar(){
            double.TryParse(Console.ReadLine(), out double nota);
            double notaCorte = 7;

            System.Console.WriteLine("Nora Invalida? {0}", nota > 10);
            System.Console.WriteLine("Nora Invalida? {0}", nota < 0);
            System.Console.WriteLine("Perfeito? {0}", nota == 10);
            System.Console.WriteLine("Tem como melhorar? {0}", nota != 10);
            System.Console.WriteLine("Tem como melhorar? {0}", nota > notaCorte);
            System.Console.WriteLine("Recuperação? {0}", nota < notaCorte);
            System.Console.WriteLine("Reprovado? {0}", nota <= 3);
        }
    }
}