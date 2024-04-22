using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppRestauranteCompra
{
    public class ClCompra
    {
        public string plato;
        public double precio;
        public int cantidad;

        public ClCompra(string nuevoPlato, double nuevoPrecio, int cantidadS)
        {
            plato = nuevoPlato;
            precio = nuevoPrecio;
            cantidad = cantidadS;
        }
    }
}
