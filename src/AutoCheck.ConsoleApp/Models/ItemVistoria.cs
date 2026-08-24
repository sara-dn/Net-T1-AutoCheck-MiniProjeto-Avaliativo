namespace AutoCheck.ConsoleApp.Models
{
    public class ItemVistoria
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public string Pendencia {get; set;}

        public ItemVistoria(string nome, string status)
        {
            this.Nome = nome;
            if (status == "bom" || status == "regular" || status == "ruim")
            {
                this.Status = status;
            }
            else
            {
                Console.WriteLine("Status inválido. Por favor inserir apenas 'bom', 'ruim' ou 'regular'");
            }
        }

        public ItemVistoria()
        {
            switch (Status)
            {
                case "ruim": 
                    this.Pendencia = "Exigem troca/reparo obrigatório.";
                    break;
                case "regular":
                    this.Pendencia = "Exigem revisão preventiva.";
                    break;
                default:
                    break;

            }
        }
    }
}