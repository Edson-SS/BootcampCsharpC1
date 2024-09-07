// See https://aka.ms/new-console-template for more information
Console.WriteLine("Arreglos");

string[] ciudades = new string[4];

ciudades[0] = "Lima";
ciudades[1] = "Piura";
ciudades[2] = "Trujillo";
ciudades[3] = "Chimbote";


for  (int i = 0; i < ciudades.Length; i++)
{
    Console.WriteLine(ciudades[i]);
}

foreach (string item in ciudades)
    { Console.WriteLine(item); }


Console.WriteLine("--------");
Console.WriteLine("Lista");
List<string> ciudadesLista = new List<string>();

ciudadesLista.Add("Lima");
ciudadesLista.Add("Bogota");

foreach (string item in ciudadesLista)
{ Console.WriteLine(item); }

ciudadesLista.Clear();

foreach (string item in ciudadesLista)
{ Console.WriteLine(item); }

Console.WriteLine("--------");
Console.WriteLine("Queue");
Queue<float> Ingresos = new Queue<float>();
Ingresos.Enqueue(25.25f);
Ingresos.Enqueue(3);
Ingresos.Enqueue(8);
Ingresos.Enqueue(58f);

foreach (var item in Ingresos)
    { Console.WriteLine(item); }

var sacaste1 = Ingresos.Dequeue();

Console.WriteLine($"Sacaste {sacaste1}");

foreach (var item in Ingresos)
{ Console.WriteLine(item); }

Console.WriteLine("--------");
Console.WriteLine("Pilas");

Stack<String> animales = new Stack<String>();

animales.Push("Loro");
animales.Push("Vaca");
animales.Push("Canario");
animales.Push("Perro");
animales.Push("Gato");

foreach (var item in animales)
{ Console.WriteLine(item); }

string animalRetirado = animales.Pop();

Console.WriteLine($"El animal retirado {animalRetirado}");

Console.WriteLine("Nueva Pila");
foreach (var item in animales)
{ Console.WriteLine(item); }