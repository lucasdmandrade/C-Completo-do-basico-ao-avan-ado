using System;
using System.Collections.Generic;

namespace CSharp_zero_ao_avancado.Colecoes
{
    public class ColecoesSet
    {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8° Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            System.Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach( var item in carrinho ){
                //System.Console.WriteLine(carrinho.IndexOf(item));
                System.Console.WriteLine($"{item.Nome} {item.Preco}");

                System.Console.WriteLine(carrinho.Count);
                carrinho.Add(livro);
                System.Console.WriteLine(carrinho.Count);
            }
        }
    }
}