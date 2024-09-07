// See https://aka.ms/new-console-template for more information
using POO;

List<Guerrero> Guerreros = new List<Guerrero>();
int opciones = 0;

while (opciones != 5)
{
    Console.WriteLine("Menu");
    Console.WriteLine("1. Crea tu Guerrero");
    Console.WriteLine("2. Ver Guerrero");
    Console.WriteLine("3. Eliminar Guerrero");
    Console.WriteLine("4. Buscar por ID");
    Console.WriteLine("5. Salir");

    Console.WriteLine("Selecciona tu Opcion");
    opciones = int.Parse(Console.ReadLine());

    switch(opciones)
    {

        case 1:
            Console.WriteLine("Ingresa el nombre del Guerrero");
            string? nombre = Console.ReadLine();
            Guerrero nuevoGuerrero = new Guerrero(nombre);
            Guerreros.Add(nuevoGuerrero);
            break;

        case 2:
            foreach (Guerrero item in Guerreros)
            { 
                Console.WriteLine($"{item.id}. --> {item.nombre}");
            }
            break;

        case 3:
            Console.WriteLine("Ingresa el Id del Guerrero a eliminar");
            int idEliminado = int.Parse(Console.ReadLine());
            if (idEliminado < Guerreros.Count)
            {
                Guerreros.RemoveAt(idEliminado - 1);
                Console.WriteLine("Guerrero Eliminado");
            }
            else {
                Console.WriteLine("Este guerrero no existe");
            }
            break;
        case 4:
            Console.WriteLine("Ingresa el Id del Guerrero a buscar");
            int idBuscado = int.Parse(Console.ReadLine())-1;
            if (idBuscado < Guerreros.Count)
            {
                Console.WriteLine($"{Guerreros[idBuscado].id}. --> {Guerreros[idBuscado].nombre} encontrado");
            }
            else
            {
                Console.WriteLine("Este guerrero no existe");
            }
            break;
    }
}
Console.WriteLine("Creando Guerrero");
Console.WriteLine("Ingresa Nombre");

/*Guerrero nuevoGuerrero = new Guerrero();

nuevoGuerrero.nombre = Console.ReadLine();

Console.WriteLine($"El nombre de tu guerrero es {nuevoGuerrero.nombre}");

nuevoGuerrero.Atacar();

Console.WriteLine($"El nivel de tu guerrero es {nuevoGuerrero.nivel}");
nuevoGuerrero.RecibirExperiencia(20);
Console.WriteLine($"El nivel de tu guerrero es {nuevoGuerrero.nivel}");

Guerrero nuevoGuerrero2 = new Guerrero("G2");
Console.WriteLine($"El nombre de tu nuevo guerrero es {nuevoGuerrero2.nombre}");*/