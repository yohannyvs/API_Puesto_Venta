using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Puesto_Venta.Models;

namespace API_Puesto_Venta.Controllers
{
    public class CategoriaController : ApiController
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        // GET: api/Prueba
        public IEnumerable<string> GetCategorias()
        {
            List<string> list = new List<string>();

            var result = dc.select_categoria();

            foreach (var res in result)
            {
                list.Add(res.nombre_cat);
            }

            return list;
        }

    }
}
