// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Ingresa el numero limite");

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
} while (contador < numeroLimite);*/

Console.WriteLine("MENU DO-WHILE");
int opcion = 0;


do
{
    Console.WriteLine("Ingrese los numeros");
    double numero1 = double.Parse(Console.ReadLine());
    double numero2 = double.Parse(Console.ReadLine());
    double resultado = 0;
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

    switch (opcion)
    {
        case 1:
            resultado = numero1 + numero2;
            break;
        case 2:
            resultado = numero1 - numero2;
            break;
        case 3:
            resultado = numero1 * numero2;
            break;
        case 4:
            resultado = numero1 / numero2;
            break;
        case 5:
            resultado = Math.Pow(numero1, numero2);
            break;

    }
    Console.WriteLine($"El resultado es {Math.Round(resultado,2)}");
} while (opcion != 7);

Console.WriteLine("Salida");