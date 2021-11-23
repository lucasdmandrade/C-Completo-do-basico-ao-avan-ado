namespace CSharp_zero_ao_avancado.Colecoes
{
    public class Igualdade
    {
        public static void Executar() {
            var p1 = new Produto("Caneta", 1.99);
            var p2 = new Produto("Caneta", 1.99);
            var p3 = p2;

            System.Console.WriteLine(p1 == p2);
            System.Console.WriteLine(p3 == p2);

            System.Console.WriteLine(p1.Equals(p2));
        }
    }
}