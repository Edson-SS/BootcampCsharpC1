// See https://aka.ms/new-console-template for more information

DateTime FechaNacimiento = new DateTime(1992, 3, 19);
DateTime FechaActual = DateTime.Now;

Console.WriteLine($"NAci la fecha: {FechaNacimiento.Date.ToString("dd-MM-yyyy")}");