using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperPoder superPoder1 = new SuperPoder("Super Fuerza", "Puede levantar objetos pesados", 10);
            SuperPoder superPoder2 = new SuperPoder("Volar", "Puede volar por los aires", 8);
            SuperPoder superPoder3 = new SuperPoder("Super Velocidad", "Puede correr muy rápido", 9);

            SuperHeroe superHeroe1 = new SuperHeroe("Superman", "Clark Kent", "Metropolis", true, superPoder1);
            SuperHeroe superHeroe2 = new SuperHeroe("Batman", "Bruce Wayne", "Gotham City", false, superPoder2);
            SuperHeroe superHeroe3 = new SuperHeroe("Capitan America", "Steve Roger", "Central City", false, superPoder3);

            Console.WriteLine(superHeroe1.ToString());
            Console.WriteLine(superHeroe2.ToString());
            Console.WriteLine(superHeroe3.ToString());
        }
    }

    class SuperHeroe
    {
        public string nombre;
        public string identidadSecreta;
        public string ciudad;
        public bool puedeVolar;
        public SuperPoder superPoder;

        public SuperHeroe(string nombre, string identidadSecreta, string ciudad, bool puedeVolar, SuperPoder superPoder)
        {
            this.nombre = nombre;
            this.identidadSecreta = identidadSecreta;
            this.ciudad = ciudad;
            this.puedeVolar = puedeVolar;
            this.superPoder = superPoder;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}\nIdentidad secreta: {identidadSecreta}\nCiudad: {ciudad}\nPuede volar: {puedeVolar}\nSuper poder: {superPoder.ToString()}";
        }
    }

    class SuperPoder
    {
        public string nombre;
        public string descripcion;
        public int nivel;

        public SuperPoder(string nombre, string descripcion, int nivel)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.nivel = nivel;
        }

        public override string ToString()
        {
            return $"Nombre: {nombre}\nDescripción: {descripcion}\nNivel: {nivel}";
        }
    }
}
