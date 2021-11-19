namespace CSharp_zero_ao_avancado.Fundamentos
{
    public class NotacaoPonto
    {
        public static void Executar(){
            var saudacao = "ola".ToUpper().Insert(3, " Word")
            .Replace("Word", "Mundo");
            System.Console.WriteLine(saudacao);

            string valorImportante = null;
            //Navegação segura: Só aplica se o valor do objeto referenciado for diferente de null
            System.Console.WriteLine(valorImportante?.Length);
        }
    }
}