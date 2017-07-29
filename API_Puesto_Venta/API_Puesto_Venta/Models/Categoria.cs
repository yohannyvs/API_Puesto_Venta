using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Puesto_Venta.Models
{
    public class Categoria
    {
        private string nombre_cat;

        public Categoria() { }

        public Categoria(string nombre_cat)
        {
            this.nombre_cat = nombre_cat;
        }

        public string Nombre_cat
        {
            get { return nombre_cat; }
            set { nombre_cat = value; }
        }
    }
}