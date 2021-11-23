using System.Collections;

namespace CSharp_zero_ao_avancado.Colecoes
{
    public class ColecoesStack
    {
        public static void Executar() {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            foreach( var item in pilha) {
                System.Console.WriteLine($"{item} ");
            }

            System.Console.WriteLine($"/nPop: {pilha.Pop()}");

            System.Console.WriteLine($"/nPeek: {pilha.Peek()}");
            System.Console.WriteLine(pilha.Count);
        }
    }
}