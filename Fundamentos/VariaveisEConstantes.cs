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
            /// byte (1byte = -127 -> 128)
            /// short (2bytes = -32000 -> 32000)
            /// int (4bytes = -+2bi)
            /// long(8bytes)
            /// </summary>
            byte idade = 45;
        }
    }
}