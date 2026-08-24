using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace AutoCheck.ConsoleApp.Services
{
    public class MotorVistoria
    {
        public int NotaMaxima {get;set;}
        public int NotaObtida {get; set;}
        public double Percentual {get; private set;}
        public string StatusAprovacao {get; private set;}
        public string AcaoCorporativa {get; private set;}
        public MotorVistoria(int totaldeitems, int notaobitida)
        {
            this.NotaMaxima = totaldeitems*10;
            this.NotaObtida = notaobitida;

            //calculo do percentaul aprovação
            this.Percentual = (NotaObtida/NotaMaxima)*100;        
        }
        
        public MotorVistoria()
        {
            if(Percentual >= 90)
            {
                this.StatusAprovacao = "Aprovado com Excelência";
                this.AcaoCorporativa = "Liberado para compra/revenda imediata.";
            }
            if(Percentual >= 60 && Percentual <= 89)
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
        
    }
}