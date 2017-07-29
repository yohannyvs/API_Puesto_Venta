using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class S_Producto
    {
        private int id;
        private string nombreprod;
        private string marca;
        private int precio;
        private int cantidad;
        private string nombre_cat;

        public S_Producto() { }

        public S_Producto(int id, string nombreprod, string nombre_cat, string marca, int precio, int cantidad)
        {
            this.id = id;
            this.nombreprod = nombreprod;
            this.nombre_cat = nombre_cat;
            this.marca = marca;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombreprod
        {
            get { return nombreprod; }
            set { nombreprod = value; }
        }
        public string Nombre_cat
        {
            get { return nombre_cat; }
            set { nombre_cat = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}