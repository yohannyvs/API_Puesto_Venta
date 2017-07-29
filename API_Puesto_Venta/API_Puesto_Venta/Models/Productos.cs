using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class Productos
    {
        private string nombreprod;
        private string marca;
        private int precio;
        private int cantidad;
        private string nombre_cat;

        public Productos() { }

        public Productos(string nombreprod, string nombre_cat, string marca, int precio, int cantidad)
        {
            this.nombreprod = nombreprod;
            this.nombre_cat = nombre_cat;
            this.marca = marca;
            this.precio = precio;
            this.cantidad = cantidad;
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