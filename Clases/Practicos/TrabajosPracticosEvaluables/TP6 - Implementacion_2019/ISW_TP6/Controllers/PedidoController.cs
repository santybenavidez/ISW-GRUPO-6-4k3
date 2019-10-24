using ISW_TP6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISW_TP6.Controllers
{
    public class PedidoController : Controller
    {
        // GET: Pedido
        public ActionResult Pedido()
        {
            PedidoModel Modelo;

            try
            {
                Modelo = new PedidoModel();
                Modelo.Ciudades = DBMock.DBMock.GetAllCiudades();
                Modelo.Horas = DBMock.DBMock.GetAllHorarios();
            }
            catch (Exception ex)
            {
                ViewBag.MensajeError = ex.Message;
                return View("Error");
            }

            return View(Modelo);
        }

        [HttpPost]
        public ActionResult Crear(PedidoModel pedidoModel)
        {
            try
            {
                DBMock.DBMock.RegistrarPedido(pedidoModel);
            }
            catch(Exception ex)
            {
                ViewBag.MensajeError = ex.Message;
                return View("Error");
            }

            return View("Exito");
        }
    }
}