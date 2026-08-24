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

         public MotorVistoria(List<ItemVistoria> vistoria)
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