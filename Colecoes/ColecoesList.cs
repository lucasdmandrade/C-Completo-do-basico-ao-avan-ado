using System;
using System.Collections.Generic;

namespace CSharp_zero_ao_avancado.Colecoes
{
    public class Produto{
        public string Nome;
        public double Preco;

        public Produto( string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    public class ColecoesList
    {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8° Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10)
            };

            carrinho.AddRange(combo);
            System.Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach( var item in carrinho ){
                System.Console.WriteLine(carrinho.IndexOf(item));
                System.Console.WriteLine($"{item.Nome} {item.Preco}");
            }
        }
    }
}