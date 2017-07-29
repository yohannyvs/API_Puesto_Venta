using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Puesto_Venta.Models;

namespace API_Puesto_Venta.Controllers
{
    public class PruebaController : ApiController
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

        /* GET: api/Prueba/5
        [HttpGet]
        public string Get(string id)
        {
            return "value " + id;
        }*/



        // POST: api/Prueba
        [HttpPost]
        public IHttpActionResult Post(Categoria value)
        {
            int res = dc.insert_catalogo(value.Nombre_cat);

            return Ok();
        }

        // PUT: api/Prueba/5
        public void Put(int id, [FromBody]Productos value)
        {

        }

        // DELETE: api/Prueba/5
        [HttpDelete]
        public void Delete(int id)
        {
            int res = dc.delete_catalogo(id);
        }
    }
}
