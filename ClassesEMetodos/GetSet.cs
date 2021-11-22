namespace CSharp_zero_ao_avancado.ClassesEMetodos
{
    public class Moto{
        private string Marca;
        private string Modelo;
        private uint Cilindradas;

        public Moto(string marca, string modelo, uint cilindradas){
            //Marca = marca;
            //Modelo = modelo;
            //Cilindradas = cilindradas;

            SetMarca(marca);
            SetModelo(modelo);
            SetCilindradas(cilindradas);
        }
        public Moto(){

        }
        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
         public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindradas() {
            return Cilindradas;
        }
        public void SetCilindradas(uint cilindradas) {
            //if(cilindradas > 0){
            //    Cilindradas = cilindradas;
            //}

            //Cilindrada = Math.abs(cilindrada);

            Cilindradas = cilindradas;
        }
    }
    public class GetSet
    {
        public static void Executar(){
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            System.Console.WriteLine(moto1.GetMarca());
            System.Console.WriteLine(moto1.GetModelo());
            System.Console.WriteLine(moto1.GetCilindradas());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindradas(150);

            System.Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo());
            System.Console.WriteLine(moto2.GetCilindradas());
        }
    }
}