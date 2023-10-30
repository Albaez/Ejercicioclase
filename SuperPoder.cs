using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicioclase
{
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
