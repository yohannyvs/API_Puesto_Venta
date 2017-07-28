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
        
        public IEnumerable<string> Get()
        {
            List<string> list = new List<string>();

            var result = dc.select_categoria();

            foreach (var res in result)
            {
                list.Add(res.nombre_cat);
            }

            return list;
        }

        // GET: api/Prueba/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Prueba
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Prueba/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Prueba/5
        public void Delete(int id)
        {
        }
    }
}
