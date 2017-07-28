using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class Carrito
    {
        private int cod_des;
        private int cedula;
        private int cod_prod;
        private int cantidad;

        public Carrito() { }

        public Carrito(int cod_des, int cedula, int cod_prod, int cantidad)
        {
            this.cod_des = cod_des;
            this.cedula = cedula;
            this.cod_prod = cod_prod;
            this.cantidad = cantidad;
        }

        public int Cod_des
        {
            get { return cod_des; }
            set { cod_des = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public int Cod_prod
        {
            get { return cod_prod; }
            set { cod_prod = value; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
    }
}