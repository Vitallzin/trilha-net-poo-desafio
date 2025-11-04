namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        
                public Iphone(string numero, string Modelo, string IMEI, string Memoria) : base(numero, Modelo, IMEI, Memoria)
        {
            
        }

       
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}