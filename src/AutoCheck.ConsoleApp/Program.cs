using System.Collections;
using AutoCheck.ConsoleApp.Models;
using AutoCheck.ConsoleApp.Services;
using Microsoft.VisualBasic;

//memoria
List<MotorVistoria> VistoriasMemoria = new();

bool menu = true;
do
{
    Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("++++Bem Vindo(a)! Ao sistema de vistoria+++++++");
    Console.WriteLine("Esculha uma das opções abaixo:");
    Console.WriteLine("1 - Realizar Nova Vistoria");
    Console.WriteLine("2 - Exibir Relatório das Vistoria");
    Console.WriteLine("0 - Sair");
    char opcao = Console.ReadKey(true).KeyChar;
    switch (opcao)
    {
        case '1':
            string marca;
            string modelo;
            int ano;
            int quilometragem;
            Console.WriteLine("Por Favor. Qual tipo de veiculo sera vistoriado:");
            string tipoVeiculo = Console.ReadLine();
            switch (tipoVeiculo)
            {
                case "carro":
                    int portas;
                    Console.WriteLine("Marca:");
                    marca = Console.ReadLine();
                    Console.WriteLine("Modelo:");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Ano:");
                    if (!int.TryParse(Console.ReadLine(), out ano))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    Console.WriteLine("Quilometragem:");
                    if (!int.TryParse(Console.ReadLine(), out quilometragem))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    Console.WriteLine("Portas:");
                    if (!int.TryParse(Console.ReadLine(), out portas))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    var carro = new Carro(marca, modelo, ano, quilometragem, portas);
                    
                    //avaliação
                    Console.WriteLine("Por Favor, avalie os intens a seguir");
                    foreach(var itens in carro.ObterChecklistObrigatorio())
                    {
                        string status;
                        Console.WriteLine($"Avalie '{itens}' (bom),(regular),(ruim):");
                        status = Console.ReadLine();
                        status = status.ToLower();
                        carro.AdicionarItemVistoriado(itens, status);
                    }
                    //iniciando vistoria
                    carro.IniciarVistoria();
                    VistoriasMemoria.Add(carro.Vistoria);
                    Console.WriteLine("Vistoria realizada com sucesso...");
                    break;
                case "caminhao":
                    int eixos;
                    double carga;
                    Console.WriteLine("Marca:");
                    marca = Console.ReadLine();
                    Console.WriteLine("Modelo:");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Ano:");
                    if (!int.TryParse(Console.ReadLine(), out ano))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    Console.WriteLine("Quilometragem:");
                    if (!int.TryParse(Console.ReadLine(), out quilometragem))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    Console.WriteLine("Eixo:");
                    if (!int.TryParse(Console.ReadLine(), out eixos))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                                        Console.WriteLine("Carga:");
                    if (!double.TryParse(Console.ReadLine(), out carga))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    var caminhao = new Caminhao(marca, modelo, ano, quilometragem, eixos, carga);
                    
                    //avaliação
                    Console.WriteLine("Por Favor, avalie os intens a seguir");
                    foreach(var itens in caminhao.ObterChecklistObrigatorio())
                    {
                        string status;
                        Console.WriteLine($"Avalie '{itens}' (bom),(regular),(ruim):");
                        status = Console.ReadLine();
                        status = status.ToLower();
                        caminhao.AdicionarItemVistoriado(itens, status);
                    }
                    //iniciando vistoria
                    caminhao.IniciarVistoria();
                    VistoriasMemoria.Add(caminhao.Vistoria);
                    Console.WriteLine("Vistoria realizada com sucesso...");
                    break;
                case "moto":
                    int cilindradas;
                    Console.WriteLine("Marca:");
                    marca = Console.ReadLine();
                    Console.WriteLine("Modelo:");
                    modelo = Console.ReadLine();
                    Console.WriteLine("Ano:");
                    if (!int.TryParse(Console.ReadLine(), out ano))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    Console.WriteLine("Quilometragem:");
                    if (!int.TryParse(Console.ReadLine(), out quilometragem))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    Console.WriteLine("Cilindradas:");
                    if (!int.TryParse(Console.ReadLine(), out cilindradas))
                    {
                        Console.WriteLine("Por favor, digite apenas números inteiros.");
                    }
                    var moto = new Moto(marca, modelo, ano, quilometragem, cilindradas);
                    
                    //avaliação
                    Console.WriteLine("Por Favor, avalie os intens a seguir");
                    foreach(var itens in moto.ObterChecklistObrigatorio())
                    {
                        string status;
                        Console.WriteLine($"Avalie '{itens}' (bom),(regular),(ruim):");
                        status = Console.ReadLine();
                        status = status.ToLower();
                        moto.AdicionarItemVistoriado(itens, status);
                    }
                    //iniciando vistoria
                    moto.IniciarVistoria();
                    VistoriasMemoria.Add(moto.Vistoria);
                    Console.WriteLine("Vistoria realizada com sucesso...");
                    break;
                default:
                    Console.WriteLine("Por favor, digite apenas 'carro', 'caminhao' ou 'moto'");
                    break;
            }
            break;
        case '2':
            if(VistoriasMemoria.Count == 0)
            {
                Console.WriteLine("Não a nenhuma Vistoria. Tente novamente mais tarde.");
            }
            else
            {
                foreach(var vistoria in VistoriasMemoria)
                {
                    vistoria.RelatorioDeVistoria();
                }
            }
            break;
        case '0':
        menu = false;
            break;
        default:
            Console.WriteLine("Por favor! Apenas '1', '2' ou '3'");
            break;
    }
}while (menu);
