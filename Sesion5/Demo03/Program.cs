
void ejemploDoWhile()
{
    int valor = 0;
    do
    {
        valor++;
        Console.WriteLine(valor);
    } while (valor < 12);

    Console.Read();
}

void leerNumerosPositivos()
{
    int numero = 0;
    do { 
        Console.Write("Ingresa el numero positivo: ");
        numero=Convert.ToInt32(Console.ReadLine());
    } while (numero <= 0);
    Console.WriteLine("Numero positivo:" + numero);
}

void leerNota()
{
    int nota = 0;
    do
    {
        Console.Write("Ingresa nota: ");
        nota = Convert.ToInt32(Console.ReadLine());
    } while (nota < 0 || nota >20);
    Console.WriteLine("Su nota es:" + nota);
}

//int numero;
//Console.Write("Ingresa un numero: ");
//numero = Convert.ToInt32( Console.ReadLine());

//Console.Write("El doble del numero es: ");
//Console.WriteLine(numero*2);

//leerNumerosPositivos();

leerNota();

Console.Read();
