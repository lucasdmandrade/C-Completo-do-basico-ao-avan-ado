namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }
        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            System.Console.WriteLine(a);

            AlterarOut(out int b);
            System.Console.WriteLine(b);
        }
    }
}