namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class OperadoresAritimetricos
    {
        public static void Executar(){
            //Preço com desconto 
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            System.Console.WriteLine("O preço final é  {0} ", totalComDesconto);

            //IMC
            double peso = 91.2;
            double altura = 1.82;
            double imc = peso / (altura * altura);
            System.Console.WriteLine($"IMC: {imc}");

            int par = 24;
            int impar = 75;
            System.Console.WriteLine("{0}/2 tem resto {1}", par, par%2);
            System.Console.WriteLine("{0}/2 tem resto {1}", impar, impar%2);

        }
    }
}