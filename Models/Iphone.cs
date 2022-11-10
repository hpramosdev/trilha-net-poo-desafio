namespace DesafioPOO.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string numero, string? modelo, string? iMEI, int memoria) : base(numero, modelo, iMEI, memoria)
        {
        
        }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando aplicativo... \nAplicativo {nome.ToUpper()} instalado com sucesso!!");
        }

    }

}