namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class Interpolacao
    {
        public static void Executar(){
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800;

            System.Console.WriteLine("O " + nome  + " da marca " + marca 
            + " custa " + preco + ".");

            System.Console.WriteLine("O {0} da marca {1} custa {2}", nome, marca, preco);

            System.Console.WriteLine($"O {nome} da marca {marca} custa {preco}");
        }
    }
}