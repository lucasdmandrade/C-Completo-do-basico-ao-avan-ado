namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class CalcualadoraEstatica{
        public int Somar(int a, int b){
            return a + b;
        }
        public static int Multiplicar(int a, int b){
            return a * b;
        }
    }
    public class MetodosEstaticos
    {
        public static void Executar() {
            var resultado = CalcualadoraEstatica.Multiplicar(2, 2);
            CalcualadoraEstatica calc = new CalcualadoraEstatica();
            System.Console.WriteLine("Resultado: {0}", resultado);
            System.Console.WriteLine(calc.Somar(2, 2));
        }
    }
}