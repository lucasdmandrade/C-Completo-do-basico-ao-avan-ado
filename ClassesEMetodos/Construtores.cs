namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class Construtores
    {
        class Carro {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano) {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
            public Carro(){
                
            }
        }
        public static void Executar(){
            var carro1 = new Carro();
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            System.Console.WriteLine(
                $"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

                var carro2 = new Carro("Ka", "Ford", 2018);
                System.Console.WriteLine(
                    $"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

                var carro3 = new Carro() {
                    Fabricante = "Fiat",
                    Modelo = "Uno",
                    Ano = 2017,
                };
                System.Console.WriteLine(
                    $"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");

        }
    }
}