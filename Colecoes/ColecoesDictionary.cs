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
                System.Console.WriteLine("2001 " + filmes.GetValueOrDefault(2001));
            }

            System.Console.WriteLine(filmes.ContainsValue("Amnesia"));
            System.Console.WriteLine($"Removeu {filmes.Remove(2004)}");
            filmes.TryGetValue(2002, out string filme2002);
            System.Console.WriteLine($"Filme 2002 {filme2002}");

            foreach( var chave in filmes.Keys) {
                System.Console.WriteLine(chave);
            }
            foreach ( var valor in filmes.Values) {
                System.Console.WriteLine(valor);
            }
            foreach ( KeyValuePair< int, string > filme in filmes) {
                System.Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}