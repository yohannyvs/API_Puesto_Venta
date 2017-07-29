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
        public IEnumerable<Productos> GetProductos()
        {
            List<Productos> list = new List<Productos>();

            var result = dc.select_productos();

            foreach (var res in result)
            {
                list.Add(new Productos(
                        res.nombreprod,
                        res.nombre_cat,
                        res.marca,
                        res.precio,
                        res.cantidad
                    ));
            }

            return list;
        }

        [HttpGet]
        public IEnumerable<Productos> GetProducto(string categoria)
        {
            List<Productos> list = new List<Productos>();

            var result = dc.select_productos();

            foreach (var res in result)
            {
                if (res.nombre_cat == categoria)
                {
                    list.Add(new Productos(
                        res.nombreprod,
                        res.nombre_cat,
                        res.marca,
                        res.precio,
                        res.cantidad
                    ));
                } 
            }

            return list;
        }
    }
}
