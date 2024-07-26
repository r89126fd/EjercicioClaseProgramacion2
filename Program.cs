using System;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creacion de superpoderes
            SuperPoder superPoder1 = new SuperPoder("Vuelo", "Puede volar a grandes velocidades", 5);
            SuperPoder superPoder2 = new SuperPoder("Superfuerza", "Posee una fuerza sobrehumana", 4);
            SuperPoder superPoder3 = new SuperPoder("Invisibilidad", "Puede hacerse invisible", 3);

            // Creacion de superheroes
            SuperHeroe superHeroe1 = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, superPoder1);
            SuperHeroe superHeroe2 = new SuperHeroe("Hulk", "Bruce Banner", "Nueva York", false, superPoder2);
            SuperHeroe superHeroe3 = new SuperHeroe("Invisible Woman", "Sue Storm", "Nueva York", false, superPoder3);

            // Mostrar informacion de los superheroes
            superHeroe1.MostrarInformacion();
            superHeroe2.MostrarInformacion();
            superHeroe3.MostrarInformacion();
        }
    }

    class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder SuperPoder { get; set; }

        public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
        {
            Nombre = nombre;
            IdentidadSecreta = identidadSecreta;
            Ciudad = ciudad;
            PuedeVolar = puedeVolar;
            SuperPoder = superPoder;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Identidad Secreta: " + IdentidadSecreta);
            Console.WriteLine("Ciudad: " + Ciudad);
            Console.WriteLine("Puede Volar: " + (PuedeVolar ? "Sí" : "No"));
            Console.WriteLine("Superpoder: " + SuperPoder.Nombre);
            Console.WriteLine("Descripcion del Superpoder: " + SuperPoder.Descripcion);
            Console.WriteLine("Nivel del Superpoder: " + SuperPoder.Nivel);
            Console.WriteLine();
        }
    }

    class SuperPoder
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Nivel { get; set; }

        public SuperPoder(string nombre, string descripcion, int nivel)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Nivel = nivel;
        }
    }
}
