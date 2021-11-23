using System.Collections.Generic;

namespace CSharp_zero_ao_avancado.Colecoes
{
    public class ColecoesDictionary
    {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2001, "Os incriveis");
            filmes.Add(2002, "Tropa de Elite");

            if(filmes.ContainsKey(2001)) {
                System.Console.WriteLine("2001 " + filmes[2001]);
            }
        }
    }
}