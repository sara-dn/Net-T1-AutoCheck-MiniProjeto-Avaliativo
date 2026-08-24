using System.Collections;
using AutoCheck.ConsoleApp.Models;
using AutoCheck.ConsoleApp.Services;
using Microsoft.VisualBasic;
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
            Console.WriteLine("1");
            break;
        case '2':
            Console.WriteLine("2");
            break;
        case '0':
        menu = false;
            break;
        default:
            Console.WriteLine("Por favor! Apenas '1', '2' ou '3'");
            break;
    }
}while (menu);

/* var carro1 = new Carro("Chevrolet", "Impala", 67, 666666, 4);
var moto1 = new Moto("toyota", "Kawazaki", 2005, 2000, 80);
var caminhao1 = new Caminhao("MarcaFamosa", "ModeloFamoso", 1999, 26000, 4, 40.5);

Console.WriteLine("carro:");
foreach (var checklist in carro1.ObterChecklistObrigatorio())
{
    Console.WriteLine(checklist);
}

Console.WriteLine("moto:");
foreach (var checklist in moto1.ObterChecklistObrigatorio())
{
    Console.WriteLine(checklist);
}

Console.WriteLine("caminhao:");
foreach (var checklist in caminhao1.ObterChecklistObrigatorio())
{
    Console.WriteLine(checklist);
}

Console.WriteLine("********TESTE DE ItemsVistoria********");
var item1 = new ItemVistoria("Item 1", "bom");
Console.WriteLine($"Item: {item1.Nome}, Status: {item1.Status}");

var item2 = new ItemVistoria("Item 2", "erradu, eu sei eu sei");
Console.WriteLine($"Item: {item2.Nome}, Status: {item2.Status}");

//teste MotorVistoria
Console.WriteLine("********TESTE DE MotorVistoria********");
foreach(var itens in carro1.ObterChecklistObrigatorio())
{
    Console.WriteLine($"Avalie '{itens}' (bom),(regular),(ruim):");
    carro1.AdicionarItemVistoriado(itens, Console.ReadLine());
}
carro1.IniciarVistoria();
List<MotorVistoria> VistoriasRealizadas = new();

VistoriasRealizadas.Add(carro1.Vistoria);

Console.WriteLine($"acão corporativa: {VistoriasRealizadas[0].AcaoCorporativa}");
 */