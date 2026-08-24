using AutoCheck.ConsoleApp.Models;

var carro1 = new Carro("Chevrolet", "Impala", 67, 666666, 4);
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

