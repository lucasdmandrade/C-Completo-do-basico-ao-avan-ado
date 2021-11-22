namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class Produto{
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto){
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto(){

        }
        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }
    public class AtributosEstaticos
    {
        public static void Executar(){
            var produto1 = new Produto("Caneta", 3.2, 0.1);
            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3
            };
            Produto.Desconto = 0.5;

            System.Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            System.Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");

            Produto.Desconto = 0.02;

            System.Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            System.Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");
        }
    }
}