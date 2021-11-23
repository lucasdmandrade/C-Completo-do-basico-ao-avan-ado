namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public struct SPonto{
        public int X;
        public int Y;
    }
    public class CPonto{
        public int X;
        public int Y;
    }
    public class StructVsClasses
    {
        public static void Executar() {
            SPonto ponto1 = new SPonto{ X = 1, Y = 3};
            SPonto copiaPonto1 = ponto1;
            ponto1.X = 3;

            System.Console.WriteLine(ponto1.X);
            System.Console.WriteLine(copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 2, Y = 4};
            CPonto copiaPonto2 = ponto2;  
            ponto2.X = 5; 
            System.Console.WriteLine(ponto2.X);
            System.Console.WriteLine(copiaPonto2.X);
            
        }
    }
}