namespace CSharp_zero_ao_avancado.Colecoes
{
    public class Array
    {
        public static void Executar() {
            string[ ] alunos = new string[5];
            alunos[0] = "Anderson";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Daniela";
            alunos[4] = "Emanuel";

            foreach( var aluno in alunos) {
                System.Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };

            foreach(var nota in notas ){
                somatorio += nota;
            }

            double media = somatorio / notas.Length;

            System.Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y'};
            string palavra = new string (letras);
            System.Console.WriteLine(palavra);
        }
    }
}