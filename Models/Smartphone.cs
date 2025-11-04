namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
        protected string Memoria { get; set; }

        public Smartphone(string numero, string Modelo, string IMEI, string Memoria)
        {
            Numero = numero;
            this.Modelo = Modelo;
            this.IMEI = IMEI;
            this.Memoria = Memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}