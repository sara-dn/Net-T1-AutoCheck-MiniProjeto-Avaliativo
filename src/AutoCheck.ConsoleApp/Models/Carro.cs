namespace AutoCheck.ConsoleApp.Models
{
    public class Carro:Veiculo
    {
        //Atributos
        public int QuantidadeDePortas {get; set;}

        //construtor
        public Carro(string marca, string modelo, int ano, int quilometragem, int quantidadedeportas )
            :base(marca, modelo, ano, quilometragem)
        {
            this.QuantidadeDePortas = quantidadedeportas;
        }
    }
}