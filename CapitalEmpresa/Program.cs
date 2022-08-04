// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** CAPITAL DE EMPRESA ***");
Console.WriteLine("");

double monto1, monto2, monto3;

Console.WriteLine("ingrese el monto1 del socio1");
monto1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el montodelcio2:");
monto2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto del socio3:");
monto3 = double.Parse(Console.ReadLine());

double capial = monto1 + monto2 + monto3;

double socio1 = (monto1 * 100) / capial;
double socio2 = (monto2 * 100) / capial;
double socio3 = (monto3 * 100) / capial;

Console.WriteLine("----------------");

Console.WriteLine("CAPITAL:" + capial.ToString("0.00"));
Console.WriteLine("Socio1 : " + socio1.ToString("0.00"));
Console.WriteLine("Socio2 : " + socio2.ToString("0.00"));
Console.WriteLine("socio3 : " + socio3.ToString("0.00"));


