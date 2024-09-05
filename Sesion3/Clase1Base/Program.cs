// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola! Alumnos");

string Nombre = "Edson";
long altura = 170;
int edad = 20;
char letra = 'A';
double dinero = 1543.21;

Console.WriteLine("Escribe tu Nombre:");
Nombre = Console.ReadLine();
Console.WriteLine("Tu Nombre es " + Nombre);
Console.WriteLine("Escribe tu edad");
edad = int.Parse(Console.ReadLine());
Console.WriteLine($"Tu edad es {edad}");

if (edad >= 18) 
{
    Console.WriteLine("Puedes Ingresar");
}
else
{
    Console.WriteLine("No puedes Ingresar");
}