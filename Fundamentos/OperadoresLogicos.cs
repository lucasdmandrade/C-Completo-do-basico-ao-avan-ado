namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class OperadoresLogicos
    {
        public static void Executar(){
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            var comprouTv = executouTrabalho1 && executouTrabalho2;
            System.Console.WriteLine(comprouTv);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            System.Console.WriteLine(comprouSorvete);
        }
    }
}