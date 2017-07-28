using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class Productos
    {
        private int cod_prod;
        private string nombreprod;
        private string marca;
        private int precio;
        private int cantidad;

        public Productos() { }

        public Productos(int cod_prod, string nombreprod, string marca, int precio, int cantidad)
        {
            this.cod_prod = cod_prod;
            this.nombreprod = nombreprod;
            this.marca = marca;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public int Cod_prod
        {
            get { return cod_prod; }
            set { cod_prod = value; }
        }
        public string Nombreprod
        {
            get { return nombreprod; }
            set { nombreprod = value; }
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