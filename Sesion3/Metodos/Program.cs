// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double num1 = 3;
double num2 = 6;
double resultado = 0;
void Sumar(int n1, int n2)
{
    resultado = n1 + n2;
}

void Sumar2()
{
    resultado = num1 + num2;
}
double Sumar4 (double n1,double n2)
{
    return n1 + n2;
}

Func<int,int,int> SumaLamda = (n1,n2) => (n1+n2);

Sumar2();
Console.WriteLine($"Sumando 1 con void {resultado}");
Sumar(5, 6);
Console.WriteLine($"Sumando 2 con void {resultado}");
Console.WriteLine($"Sumando 3 con return {SumaLamda(5, 6)}");
Console.WriteLine($"Sumando 4 con Lamda {SumaLamda(5, 6)}");
