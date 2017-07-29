using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Puesto_Venta.Models;

namespace API_Puesto_Venta.Controllers
{
    public class ProductosController : ApiController
    {
        DataClassesDataContext dc = new DataClassesDataContext();
        // GET: api/Prueba

        [HttpGet]
        public IEnumerable<S_Producto> GetProductos()
        {
            List<S_Producto> list = new List<S_Producto>();

            var result = dc.select_productos();

            foreach (var res in result)
            {
                list.Add(new S_Producto(
                        res.cod_prod,
                        res.nombreprod,
                        res.nombre_cat,
                        res.marca,
                        res.precio,
                        res.cantidad
                    ));
            }

            return list;
        }

        [HttpPost]
        public IHttpActionResult Add_Producto(Productos value)
        {
            int res = dc.insert_producto(
                    value.Nombreprod,
                    value.Cod_cat,
                    value.Marca,
                    value.Precio,
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
        public void Delete_Producto(int value)
        {
            int res = dc.delete_producto(value);
        }
    }
}
