// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** control de venta de productos  ***");
Console.WriteLine("");

double Precio, Cantidad;

Console.WriteLine("Ingres el precio...: ");
Precio = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad...: ");
Cantidad = double.Parse(Console.ReadLine());

double Importe = Precio * Cantidad;
double Descuento =  Importe * 11 / 100;

double Total = Importe - Descuento;

Console.WriteLine("--------------------------------------------- " );
Console.WriteLine("El TOTAL DEL IMPORTE ES...: " + Importe.ToString("0.00"));
Console.WriteLine("El TOTAL DEL DESCUENTO FUE DE...: " + Descuento.ToString("0.00"));
Console.WriteLine("");

Console.WriteLine("El TOTAL NETA ES DE...: " + Total.ToString("0.00"));
Console.WriteLine("**************************************************");

Console.WriteLine("Gracias por utilizar el programa :)");