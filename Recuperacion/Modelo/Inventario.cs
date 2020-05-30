using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
        //Declarar las variables publicas, cambio de string a int en idArticulo, stock y double a precio
        public int idArticulo { get; }
        public string producto { get; }
        public string descripcion { get; }
        public double precio { get; }
        public int stock { get; }

        //Cambio de string a int en idArticulo, stock y double a precio
        public Inventario(int idArticulo, string producto, string descripcion, double precio, int stock)
        {
            this.idArticulo = idArticulo;
            this.producto = producto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
