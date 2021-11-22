namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class Params
    {
        public static void Recepcionar(params string[] pessoas){
            foreach( var pessoa in pessoas) {
                System.Console.WriteLine($"Ola {pessoa}");
            }
        }
        public static void Executar(){
            Recepcionar("Lucas", "Pedro", "Manu");
        }
    }
}