// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa el numero limite");

int numeroLimite = int.Parse(Console.ReadLine());
int contador = 0;

while (contador < numeroLimite)
{
    contador++;
    Console.WriteLine(contador);
}

Console.WriteLine("DO-WHILE");
contador = 0;
do
{
    contador++;
    Console.WriteLine(contador);
} while (contador < numeroLimite);

Console.WriteLine("MENU DO-WHILE");
int opcion = 0;
do
{
    Console.WriteLine("Calculadora ---->");
    Console.WriteLine("1 -Sumar");
    Console.WriteLine("2 -Restar");
    Console.WriteLine("3 -Multiplar");
    Console.WriteLine("4 -Dividir");
    Console.WriteLine("5 -Potencia");
    Console.WriteLine("6 -Raiz");
    Console.WriteLine("7 -Salida");

    Console.WriteLine("Ingresa tu opcion:");
    opcion = int.Parse(Console.ReadLine());
    if (opcion == 1)
        Console.WriteLine("Sumando");
    if (opcion == 2)
        Console.WriteLine("Restando");
} while (opcion != 7);

Console.WriteLine("Salida");