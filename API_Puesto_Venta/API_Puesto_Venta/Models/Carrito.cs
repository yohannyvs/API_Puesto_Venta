using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class Carrito
    {
        private int cod_des;
        private string correo;
        private int cod_prod;
        private string nombre_prod;
        private int cantidad;
        private int precio;

        public Carrito() { }

        public Carrito(int cod_des, int cod_prod, string nombre_prod, int cantidad, int precio)
        {
            this.cod_des = cod_des;
            this.cod_prod = cod_prod;
            this.nombre_prod = nombre_prod;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public Carrito(string correo, int cod_prod, int cantidad)
        {
            this.correo = correo;
            this.cod_prod = cod_prod;
            this.cantidad = cantidad;
        }

        public int Cod_des
        {
            get { return cod_des; }
            set { cod_des = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public int Cod_prod
        {
            get { return cod_prod; }
            set { cod_prod = value; }
        }
        public string Nombre_prod
        {
            get { return nombre_prod; }
            set { nombre_prod = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}