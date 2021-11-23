using System;

namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class Cliente{
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento(){
            return String.Format($"{Nascimento.Day}/{Nascimento.Month}/{Nascimento.Year}");
        }
    }
    public class Readonly
    {
        public static void Executar(){
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            System.Console.WriteLine(novoCliente.Nome);
            System.Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}