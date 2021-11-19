namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class VariaveisEConstantes
    {
        public static void Executar(){
            double raio = 4.5;
            const double PI = 3.14159;

            raio = 5.5;
            double area = PI * raio * raio;
            System.Console.WriteLine(area);
            System.Console.WriteLine("Area é " + area);

            bool estaChovendo = true;
            System.Console.WriteLine("Esta chovendo" + estaChovendo);

            /// <summary tipo inteiro>
            /// byte (1byte = 0 -> 257)
            /// sbyte (1byte = -127 -> 128)
            /// short (2bytes = -32000 -> 32000)
            /// int (4bytes = -+2bi)
            /// long(8bytes)
            /// </summary>
            byte idade = 45;

            int menorValorInt = int.MinValue;
            System.Console.WriteLine("Menor valor possivel do int "+ menorValorInt);

            //Inteiro sem sinal
            uint populacaoBrasileira = 207_600_000;
            //Pode se usar underline(____) para facilitar leitura numerica sem alterar seu valor
            System.Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long populacaoMundial = 7600000000;
            System.Console.WriteLine("Populacão mundial "+ populacaoMundial);

            decimal distanciaEsntreEstrelas = decimal.MaxValue;
            System.Console.WriteLine("Tamanho maximo decimal" + distanciaEsntreEstrelas);


            //1 Letra usa aspas simples '' 
            //Cadeia de letras usa aspas duplas ""
            char letra = 'b';
            System.Console.WriteLine("Letra " + letra);

            string texto = "Bem vindo";
            System.Console.WriteLine(texto);
        }
    }
}