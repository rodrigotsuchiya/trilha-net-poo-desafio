namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero) { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine($"Nokia ja instalou o seu app {nomeApp}");
        }
    }
}