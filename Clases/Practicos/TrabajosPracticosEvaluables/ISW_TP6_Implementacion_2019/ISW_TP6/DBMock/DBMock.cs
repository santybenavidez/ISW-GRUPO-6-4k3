using ISW_TP6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISW_TP6.DBMock
{
    public static class DBMock
    {
        public static List<SelectListItem> GetAllCiudades()
        {
            List<SelectListItem> CiudadesList;

            try
            {
                CiudadesList = new List<SelectListItem>()
                {
                    new SelectListItem(){ Value = "1", Text = "Córdoba"},
                    new SelectListItem(){ Value = "2", Text = "Buenos Aires"},
                    new SelectListItem(){ Value = "3", Text = "Mar del Plata"},
                    new SelectListItem(){ Value = "4", Text = "Rosario"}
                };
                return CiudadesList;
            }
            catch
            {
                throw;
            }
        }

        public static List<SelectListItem> GetAllHorarios()
        {
            List<SelectListItem> HorariosList;

            try
            {
                HorariosList = new List<SelectListItem>()
                {
                    new SelectListItem(){ Value = "1", Text = "Lo antes posible"},
                    new SelectListItem(){ Value = "2", Text = "Entre las 8:00 y las 10:00"},
                    new SelectListItem(){ Value = "3", Text = "Entre las 10:00 y las 12:00"},
                    new SelectListItem(){ Value = "4", Text = "Entre las 12:00 y las 14:00"},
                    new SelectListItem(){ Value = "4", Text = "Entre las 14:00 y las 16:00"}
                };
                return HorariosList;
            }
            catch
            {
                throw;
            }
        }

        public static void RegistrarPedido(PedidoModel pedidoModel)
        {
            try
            {
                // Implementación...
            }
            catch
            {
                throw;
            }
        }

    }
}