using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2PED_MO232723
{
    public class Productos
    {
        // Definimos variables
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int CantStock { get; set; }

        public Productos(string codigo, string nombre, string categoria, decimal precio, int cantidadStock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Precio = precio;
            CantStock = cantidadStock;
        }
        // constructor
        public Productos() { }
    }
}
