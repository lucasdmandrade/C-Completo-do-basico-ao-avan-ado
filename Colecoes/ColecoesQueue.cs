using System.Collections;
using System.Collections.Generic;

namespace CSharp_zero_ao_avancado.Colecoes
{
    public class ColecoesQueue
    {
        public static void Executar() {
            var fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            System.Console.WriteLine(fila.Peek());
            System.Console.WriteLine(fila.Count);

            System.Console.WriteLine(fila.Dequeue());
            System.Console.WriteLine(fila.Count);

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            System.Console.WriteLine(salada.Contains("item"));
            System.Console.WriteLine(salada.Contains("Item"));

        }
    }
}