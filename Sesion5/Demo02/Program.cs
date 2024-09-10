// See https://aka.ms/new-console-template for more information
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

Console.WriteLine(SumarNaturales(4));
Console.WriteLine($"Suma Impar: {SumarImpares(5)}");
Console.WriteLine($"Suma Impar 2: {SumarImpares2(5)}");
Console.WriteLine($"Suma Par: {SumarPares(5)}");
Console.ReadLine();