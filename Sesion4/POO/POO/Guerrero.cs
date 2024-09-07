using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Guerrero
    {
        public static int contador = 0;
        public int id = 0;
        public string nombre;
        public int nivel = 0;
        public double experiencia;
        public bool tieneorejas;
        public int orejasDeVictimas;
        public float ataque = 35f;


        public Guerrero()
        { 
        }

        public Guerrero(string nombre)
        { 
            this.nombre = nombre;
            Guerrero.contador++;
            this.id = contador;
        }

        public void Atacar()
        {
            Console.WriteLine($"{nombre} esta Atacando");
        }

        public int verNivel()
        {
            return nivel;
        }

        public void RecibirExperiencia (double nuevaExperiencia)
        {
            experiencia += nuevaExperiencia;
            if (experiencia > 10) 
            {
                nivel++;
                experiencia = 0;
            }
        }
    }
}
