namespace AutoCheck.ConsoleApp.Models
{
    public class Caminhao:Veiculo
    {
        public int QuantidadeDeEixos {get; set;}
        public double CapacidadeCargaToneladas {get; set;}

        public Caminhao(string marca, string modelo, int ano, int quilometragem, int quantidadedeeixos, double capacidadecargatoneladas )
            :base(marca, modelo, ano, quilometragem)
        {
            this.QuantidadeDeEixos = quantidadedeeixos;
            this.CapacidadeCargaToneladas = capacidadecargatoneladas;
        }
    }
}