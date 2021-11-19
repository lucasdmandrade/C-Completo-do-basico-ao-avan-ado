namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class Inferencia
    //Inferencia = reconhecimento automatico da tipagem da variavel 
    //Torna possivel criar variavel sem definir seu tipo
    {
        public static void Executar(){
            var nome = "Leonardo";
            System.Console.WriteLine(nome);

            var idade = 32;
            System.Console.WriteLine(idade);

            int a;
            a = 3;
            System.Console.WriteLine(a);
        }
    }
}