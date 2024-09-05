// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa el numero de la tabla");
int numeroTabla = int.Parse(Console.ReadLine());

for (int i = 1; i <= 12; i++)
{
    int resultado = numeroTabla * i;
    Console.WriteLine($"{numeroTabla}*{i}={resultado}");
}
