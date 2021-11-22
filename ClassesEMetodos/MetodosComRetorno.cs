namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class MetodosComRetorno
    {
        class CalculadoraComum {
            public int Somar(int a, int b) {
                return a + b;
            }
            public int Subtrair(int a, int b) {
                return a - b;
            }
            public int Multiplicar(int a, int b) {
                return a * b;
            }
            public int Dividir(int a, int b) {
                return a / b;
            }
        }
        public static void Executar(){
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            System.Console.WriteLine(resultado);
            System.Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            System.Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            System.Console.WriteLine(calculadoraComum.Dividir(25, 8));
        }
    }
}