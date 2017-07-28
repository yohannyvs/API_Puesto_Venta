using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class Categoria
    {
        private int cod_cat;
        private string nombre_cat;

        public Categoria() { }

        public Categoria(int cod_cat, string nombre_cat)
        {
            this.cod_cat = cod_cat;
            this.nombre_cat = nombre_cat;
        }

        public int Cod_cat
        {
            get { return cod_cat; }
            set { cod_cat = value; }
        }
        public string Nombre_cat
        {
            get { return nombre_cat; }
            set { nombre_cat = value; }
        }
    }
}