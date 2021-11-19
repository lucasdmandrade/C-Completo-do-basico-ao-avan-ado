using System;

namespace CSharp_zero_ao_avancado.EstruturaControle
{
    public class If
    {
        public static void Executar(){
            bool bomComportamento = false;
            string entrada;

            System.Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            if(entrada == "S" || entrada == "s"){
                bomComportamento = true;
            }

            if(nota >= 9 && bomComportamento == true)
            System.Console.WriteLine("Quadro de honra");
        }
    }
}