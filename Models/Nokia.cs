namespace DesafioPOO.Models
{
   
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, string IMEI, string Memoria) : base(numero, Modelo, IMEI, Memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
        
    }
}