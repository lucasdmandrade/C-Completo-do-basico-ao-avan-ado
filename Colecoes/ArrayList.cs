using System;
using System.Collections;

namespace CSharp_zero_ao_avancado.Colecoes
{
    public class ColecoesArrayList
    {
        public static void Executar() {
            var arrayList = new ArrayList {
                "Palavra",
                3,
                true,
            };
            arrayList.Add(3.14);

            foreach(var item in arrayList) {
                System.Console.WriteLine($"{item} => {item.GetType()}");
            }
        }
    }
}