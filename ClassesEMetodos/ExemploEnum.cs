namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public enum Genero {Acao, Aventura, Terror, Animacao, Comedia};
    public class Filme{
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    public class ExemploEnum
    {
        public static void Executar(){
            int id = (int)Genero.Animacao;
            System.Console.WriteLine(id);

            var filmePraFamilia = new Filme();
            filmePraFamilia.Titulo = "Sharknado17";
            filmePraFamilia.GeneroDoFilme = Genero.Comedia;

            System.Console.WriteLine($"{filmePraFamilia.Titulo} é do genero{filmePraFamilia.GeneroDoFilme}");
        }
    }
}