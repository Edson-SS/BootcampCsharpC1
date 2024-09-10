// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

//Crear una funcion Sumar los primeros n numeros naturales

int SumarNaturales(int cantidad)
{
    int suma = 0;
    for (int i = 1; i <= cantidad; i++)
    { suma = suma + i; }
    return suma;
}

int SumarImpares2(int cantidad)
{
    return cantidad * cantidad;
}


    int SumarImpares(int cantidad)
{
    int cantidad2 = cantidad*2;
    int suma = 0;
    for (int i = 1; i <= cantidad2; i++)
    { 
        if (i % 2 >0)
        { 
            suma = suma + i;
        }
    }
    return suma;
}

int SumarPares(int cantidad)
{
    return 2*SumarNaturales(cantidad);
}

void CrearTablaMultiplicar (int numero)
{
    int cantidad = 12;
    int i = 1;
    while (i <= cantidad) { 
        Console.WriteLine($"{numero} X {i} = {numero*i}");
        i++;
    }
}

void SumarCuadrados(int cantidad)
{
    double i = 1;
    double Suma = 0;
    while (i <= cantidad)
    {
        Suma = Suma + Math.Pow(i,2);
        i++;
    }
    Console.WriteLine($"Suma de {cantidad} Cuadrados es: {Suma}");
}

void CrearTablaMultiplicarReves(int numero)
{
    int i = 12;
    while (i > 0)
    {
        Console.WriteLine($"{numero} X {i} = {numero * i}");
        i--;
    }
}

Console.WriteLine(SumarNaturales(4));
Console.WriteLine($"Suma Impar: {SumarImpares(5)}");
Console.WriteLine($"Suma Impar 2: {SumarImpares2(5)}");
Console.WriteLine($"Suma Par: {SumarPares(5)}");
//CrearTablaMultiplicar(4);
CrearTablaMultiplicarReves(4);
SumarCuadrados(5);
Console.ReadLine();