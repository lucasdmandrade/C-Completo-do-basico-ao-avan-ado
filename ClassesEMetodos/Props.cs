namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }

        //Propriedades autoimplementadas
        public double Preco { get; set; }

        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);
            //get{
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional() {

        }
        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    public class Props
    {
        public static void Executar(){
            var op1 = new CarroOpcional("Ar Condicionado", 3499.9);
            System.Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            System.Console.WriteLine(op1.Nome);
            System.Console.WriteLine(op1.Preco);

            System.Console.WriteLine(op2.Nome);
            System.Console.WriteLine(op2.Preco);
        }
    }
}