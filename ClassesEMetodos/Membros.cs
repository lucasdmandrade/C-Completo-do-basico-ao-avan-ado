namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class Membros
    {
        public static void Executar(){
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var ApresentacaoDoFulano = fulano.Apresentar();
        }
    }
}