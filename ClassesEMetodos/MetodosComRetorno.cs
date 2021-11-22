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
        class CalculadoraCadeia{
            int memoria;

            public CalculadoraCadeia Somar(int a){
                memoria += a;
                return this;
            }

            public CalculadoraCadeia Multiplicar(int a){
                memoria *= a;
                return this;
            }

            public CalculadoraCadeia Limpar(){
                memoria = 0;
                return this;
            }

            public CalculadoraCadeia Imprimir(){
                System.Console.WriteLine(memoria);
                return this;
            }
            public int Resultado() {
                return memoria;
            }
        }
        public static void Executar(){
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            System.Console.WriteLine(resultado);
            System.Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            System.Console.WriteLine(calculadoraComum.Multiplicar(4, 4));
            System.Console.WriteLine(calculadoraComum.Dividir(25, 8));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir()
                .Limpar().Imprimir();
        }
    }
}