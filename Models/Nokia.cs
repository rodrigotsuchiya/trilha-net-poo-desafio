namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(String nomeApp)
        {
            Console.WriteLine($"Nokia ja instalou o seu app {nomeApp}");
        }
    }
}