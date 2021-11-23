namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    interface Ponto{
        void MoverNaDiagonal(int delta);
    }
    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    public class ExemploStruct
    {
        public static void Executar(){
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            System.Console.WriteLine(coordenadaInicial.X);
            System.Console.WriteLine(coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            System.Console.WriteLine("Coordenada final");
            System.Console.WriteLine(coordenadaFinal.X);
            System.Console.WriteLine(coordenadaFinal.Y);
        }
    }
}