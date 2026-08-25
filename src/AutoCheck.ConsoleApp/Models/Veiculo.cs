using System.Reflection;
using AutoCheck.ConsoleApp.Services;
using Microsoft.VisualBasic;

namespace AutoCheck.ConsoleApp.Models
{
    public abstract class Veiculo
    {
        //Atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set; }
        /* public MotorVistoria vistoria { get; set; } = new(); */
        
        public List<ItemVistoria> VistoriaRealizada { get; set; } = new List<ItemVistoria>();

        public MotorVistoria Vistoria {get;set;}
        
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
            var itemVistoriado = new ItemVistoria(nome, status);
            VistoriaRealizada.Add(itemVistoriado);
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

        public virtual void IniciarVistoria()
        {
             this.Vistoria = new MotorVistoria(VistoriaRealizada, this.Marca, this.Modelo, this.Ano, this.Quilometragem);
        }
    }
}