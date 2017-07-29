using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Puesto_Venta.Models;

namespace API_Puesto_Venta.Controllers
{
    public class CarritoController : ApiController
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        // GET: api/Prueba

        public IEnumerable<Carrito> GetCarrito()
        {
            List<Carrito> list = new List<Carrito>();

            var result = dc.select_carrito();

            foreach (var res in result)
            {
                list.Add(new Carrito(
                        res.cod_des,
                        res.cod_prod,
                        res.nombreprod,
                        res.precio,
                        res.cantidad
                    ));
            }

            return list;
        }

        [HttpPost]
        public IHttpActionResult Add_Carrito(Carrito value)
        {
            int res = dc.insert_carrito(
                    value.Correo,
                    value.Cod_prod,
                    value.Cantidad
                );

            if (res == 1)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }

        [HttpDelete]
        public IHttpActionResult Delete_Carrito(int value)
        {
            int res = dc.delete_carrito(value);

            if (res == 1)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
        }
    }
}
