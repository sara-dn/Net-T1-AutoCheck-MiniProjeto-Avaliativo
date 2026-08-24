namespace AutoCheck.ConsoleApp.Models
{
    public class Moto:Veiculo
    {
        public int Cilindradas {get; set;}

        public Moto(string marca, string modelo, int ano, int quilometragem, int cilindradas )
            :base(marca, modelo, ano, quilometragem)
        {
            this.Cilindradas = cilindradas;
        }

        public override List<string> ObterChecklistObrigatorio()
        {
            var checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Kit Transmissão/Corrente");
            checklist.Add("Manetes de Freio/Embreagem");
            checklist.Add("Pezinho Lateral");
            checklist.Add("Capacete e Viseira de Proteção");
            checklist.Add("Suspensão Dianteira e Traseira (Bengalas)");
            checklist.Add("Espelhos Retrovisores e Guidão");
            
            return checklist;
        }
    }
}