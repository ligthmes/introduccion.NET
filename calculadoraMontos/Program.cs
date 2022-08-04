// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Caculadora de montos ****");
Console.WriteLine("");

double precio;
int cantidad;

Console.WriteLine("Ingrese el precio del producto C$: ");
precio = double.Parse(Console.ReadLine());
Console.WriteLine(" Ingrese la cantidad sellecionada: ");
cantidad = int.Parse(Console.ReadLine());

double monto = precio * cantidad;

Console.WriteLine("------------------------------------");
Console.WriteLine("Monto a cancelar C$ :" + monto.ToString("0.00"));

//Console.WriteLine();





