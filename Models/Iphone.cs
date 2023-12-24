namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string phoneNumber) : base(phoneNumber) { }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine($"Iphone ja instalou o seu app {nomeApp}");
        }
    }
}