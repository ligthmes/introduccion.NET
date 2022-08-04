// See https://aka.ms/new-console-template for more information
Console.WriteLine("**** Conversion de medidad ****");
Console.WriteLine("");

double metro;


Console.WriteLine("ingrese la cantidad de  metros: ");
metro = double.Parse(Console.ReadLine());

double centimetros = metro * 100.0;
double pulgadas = centimetros / 2.54;
double pies = pulgadas / 12.0;
double yardas = pies / 3.0;

Console.WriteLine("------------------------------");
Console.WriteLine("Centrimetros : " + centimetros.ToString("0.00"));
Console.WriteLine("pulgada : " + pulgadas.ToString("0.00"));
Console.WriteLine("pies : " + pies.ToString("0.00"));
Console.WriteLine("yardas : " + yardas.ToString("0.00"));

Console.WriteLine("");

Console.WriteLine("Gracias por utilizar el programa");
