namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano){
            System.Console.WriteLine($"{dia:D2}/{mes:D2}/{ano}");
        }
        public static void Executar(){
            Formatar(mes: 1, dia: 6, ano: 1996);
        }
    }
}