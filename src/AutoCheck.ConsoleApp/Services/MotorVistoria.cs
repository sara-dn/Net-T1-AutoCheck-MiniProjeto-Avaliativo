using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using AutoCheck.ConsoleApp.Models;

namespace AutoCheck.ConsoleApp.Services
{
    public class MotorVistoria
    {
        public int NotaMaxima {get;set;}
        public int NotaObtida {get; set;}
        public double Percentual {get; private set;}
        public string StatusAprovacao {get; private set;}
        public string AcaoCorporativa {get; private set;}
        public List<ItemVistoria> Vistoria {get; set;}

        //atributos para proposito de relatorio
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        public int QuantidadeDePortas {get; set;}
        public int Cilindradas {get; set;}
        public int QuantidadeDeEixos {get; set;}
        public double CapacidadeCargaToneladas {get; set;}

         public MotorVistoria(List<ItemVistoria> vistoria, string marca, string modelo, int ano, int quilometragem, int portas = 0, int cilindradas = 0, int quantidadedeeixos = 0, double capacidadecargatoneladas = 0)
        {
            
            //preencher list Vistoria
            this.Vistoria = new List<ItemVistoria> (vistoria);
            //calcular notas
            this.NotaMaxima = CalcularNotaMaxima();
            this.NotaObtida = CalcularNotaObitida();
            //calculo do percentaul aprovação
            this.Percentual = ((double)NotaObtida/NotaMaxima)*100;

            //status de aprovação e acão corporativa
            if(Percentual >= 90)
            {
                this.StatusAprovacao = "Aprovado com Excelência";
                this.AcaoCorporativa = "Liberado para compra/revenda imediata.";
            }
            else if(Percentual >= 60 && Percentual <= 89)
            {
                this.StatusAprovacao = "Aprovado com Apontamentos";
                this.AcaoCorporativa = "Exige desconto na compra para reparos da oficina.";
            }
            else
            {
                this.StatusAprovacao = "Reprovado na Vistoria";
                this.AcaoCorporativa = "Veículo recusado pela concessionária.";
            }      
        }
        
        //métodos
        private int CalcularNotaMaxima()
        {
            return (this.Vistoria.Count*10);
        }
        private int CalcularNotaObitida()
        {
            int nota = 0;
            foreach(var checklist in Vistoria)
            {
                if(checklist.Status == "bom")
                {
                    nota += 10;
                }if(checklist.Status == "regular")
                {
                    nota += 5;
                }
            }
            return nota;
        }

        public void RelatorioDeVistoria()
        {
            Console.WriteLine("===================================================================");
            Console.WriteLine("==========================DADOS DO VEICULO=========================");
            Console.WriteLine($"Marca: {this.Marca}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Ano: {this.Ano}");
            Console.WriteLine($"Quilometragem: {this.Quilometragem}KMs");
            if(this.QuantidadeDePortas > 0)
            {
                Console.WriteLine($"Quantidade de Portas: {this.QuantidadeDePortas}");
            }
            if(this.Cilindradas > 0)
            {
                Console.WriteLine($"Cilindradas: {this.Cilindradas}CC");
            }
            if(this.QuantidadeDeEixos > 0)
            {
                Console.WriteLine($"Quantidade de Eixos: {this.QuantidadeDeEixos}");
            }
            if(this.CapacidadeCargaToneladas > 0)
            {
                Console.WriteLine($"Capacidade de Carga: {this.CapacidadeCargaToneladas} Ton.");
            }
            Console.WriteLine("                                                               ");
            Console.WriteLine("                   Relatorio de Vistoria");
            Console.WriteLine("=                                                              ");
            Console.WriteLine($"Status de Aprovação: {this.StatusAprovacao}");
            Console.WriteLine($"Ação Corporativa Recomendada: {this.AcaoCorporativa}");

            Console.WriteLine("=                                                              ");
            Console.WriteLine("                   Avalição dos Items Inspecionados");
            Console.WriteLine("                                                               ");
            foreach(var item in Vistoria)
            {
                Console.WriteLine($"Item: {item.Nome} || Pontuação: {item.Status} || Pendencia: {item.Pendencia}");
            }
        }
    }
}