namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia() { }
        public Nokia(string Numero)
        {
            Console.WriteLine(Numero);

        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp);
        }
    }
}
