namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class Dependedente {
        public string Nome;
        public int Idade;
    }
    public class ValorVsReferencia
    {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            System.Console.WriteLine($"{numero} {copiaNumero}");
            
            numero++;
            System.Console.WriteLine($"{numero} {copiaNumero}");

            Dependedente dep = new Dependedente {
                Nome = "Beto",
                Idade = 20
            };

            Dependedente copiaDep = dep;
            System.Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            System.Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            copiaDep.Idade = 21;

            System.Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            System.Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}