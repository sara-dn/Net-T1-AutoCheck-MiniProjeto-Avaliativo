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

        public override List<string> ObterChecklistObrigatorio()
        {
            var checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Tacógrafo");
            checklist.Add("Sistema de Freios a Ar");
            checklist.Add("Trava e Lona da Caçamba");
            checklist.Add("Extintor de Incêndio (Carga A/B/C)");
            checklist.Add("Estado dos Eixos e Paralamas");
            checklist.Add("Faixas Refletivas de Segurança");
            
            return checklist;
        }

        public override void Relatorio()
        {
            base.Relatorio();
            Console.WriteLine($"Eixos: {this.QuantidadeDeEixos}");
            Console.WriteLine($"Capcacidade de Carga: {this.CapacidadeCargaToneladas}KGs");
        }
    }
}