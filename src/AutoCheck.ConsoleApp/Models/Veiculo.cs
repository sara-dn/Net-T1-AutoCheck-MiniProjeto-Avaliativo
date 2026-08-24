namespace AutoCheck.ConsoleApp.Models
{
    public class Veiculo
    {
        //Atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        
        public List<ItemVistoria> VistoriaRealizada { get; set; } = new List<ItemVistoria>();
        
        //Construtor
        public Veiculo(string marca, string modelo, int ano, int quilometragem )
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Quilometragem = quilometragem;
        }

        //Métodos
        public void AdicionarItemVistoriado(string nome, string status)
        {
            //por enquanto, acho que vai instanciar objetos da classe ItemVistoria.
        }

        public virtual List<string> ObterChecklistObrigatorio()
        {
            return new List<string>
            {
            "Nível de Óleo do Motor",
            "Bateria e Sistema Elétrico",
            "Documentação Regularizada",
            "Sistema de Freios",
            "Luzes de Sinalização e Iluminação",
            "Estado de Conservação dos Pneus"
            };
        }
    }
}

/* Propriedades: Marca, Modelo, Ano, Quilometragem e List<ItemVistoria> VistoriaRealizada;
Construtor explícito utilizando a palavra-chave this para atribuição das propriedades;
Método AdicionarItemVistoriado(string nome, string status);
Método virtual List<string> ObterChecklistObrigatorio() que retorna itens genéricos de inspeção (ex: "Nível de Óleo do Motor", "Bateria e Sistema Elétrico", "Documentação Regularizada").
 */