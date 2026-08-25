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

        public  override List<string> ObterChecklistObrigatorio()
        {
            var checklist = base.ObterChecklistObrigatorio();
            checklist.Add("Estepe e Macaco");
            checklist.Add("Triângulo de Sinalização");
            checklist.Add("Ar Condicionado Funcional");
            checklist.Add("Cintos de Segurança e Travas");
            checklist.Add("Funcionamento dos Limpadores de Para-brisa");
            checklist.Add("Vidros e Retrovisores Elétricos");

            return checklist;
        }

        public override void IniciarVistoria()
        {
             this.Vistoria = new Services.MotorVistoria(VistoriaRealizada, this.Marca, this.Modelo, this.Ano, this.Quilometragem, this.QuantidadeDePortas);
        }
    }
}