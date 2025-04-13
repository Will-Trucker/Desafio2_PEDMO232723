using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Desafio2PED_MO232723
{
    public class TablaHash
    {
        private const int tamano = 3; // establecemos un tamaño

        private List<Productos>[] productos = new List<Productos>[tamano];

        public TablaHash()
        {
            for(int i = 0; i < tamano; i++)
            {
                productos[i] = new List<Productos> ();
            }
        }

        private int HashFunction (string contra)
        {
            return Math.Abs(contra.GetHashCode()) % tamano;
        }

        // Agregar los productos
        public bool AgregarProducto(Productos producto)
        {
            int indice = HashFunction(producto.Codigo);
            if (productos[indice].Any(p => p.Codigo == producto.Codigo))
            {
                return false;
            }
            productos[indice].Add(producto);
            return true;
        }

        // Buscar productos
        public Productos BuscarProducto(string codigo)
        {
            int indice = HashFunction(codigo);
            return productos[indice].FirstOrDefault(p => p.Codigo == codigo);
        }

        // Eliminar productos
        public bool EliminarProducto(string codigo)
        {
            int indice = HashFunction(codigo);
            var producto = productos[indice].FirstOrDefault(p => p.Codigo == codigo);
            if (producto != null)
            {
                productos[indice].Remove(producto);
                return true;
            }
            return false;
        }
        // Listar los productos
        public List<Productos> ListarTodosLosProductos()
        {
            return productos.SelectMany(lista => lista).ToList();
        }







    }
}
