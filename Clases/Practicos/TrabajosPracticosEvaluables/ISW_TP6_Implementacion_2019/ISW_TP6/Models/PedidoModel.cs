using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISW_TP6.Models
{
    public class PedidoModel
    {
        public PedidoModel()
        {
            Ciudades = new List<SelectListItem>();
            Horas = new List<SelectListItem>();
            FormasPago = new List<SelectListItem>()
            {
                new SelectListItem(){ Value = "1", Text = "Efectivo" },
                new SelectListItem(){ Value = "2", Text = "Tarjeta de Crédito" }
            };
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ingrese una dirección (Calle-Número).")]
        [DataType(DataType.Text, ErrorMessage = "Ingrese una dirección válida.")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        public List<SelectListItem> Ciudades { get; set; }
        [Required(ErrorMessage = "Debe seleccionar una ciudad.")]
        [Display(Name = "Ciudad")]
        public SelectListItem Ciudad { get; set; }
        [Display(Name = "Referencias")]
        public string Referencias { get; set; }
        public List<SelectListItem> Horas { get; set; }
        [Required(ErrorMessage = "Debe seleccionar un horario.")]
        [Display(Name = "Horario")]
        public SelectListItem Hora { get; set; }
        public List<SelectListItem> FormasPago { get; set; }
        [Required(ErrorMessage = "Debe seleccionar una forma de pago.")]
        [Display(Name = "Forma de Pago")]
        public SelectListItem FormaPago { get; set; }
        [DataType(DataType.CreditCard, ErrorMessage = "Ingrese un número de tarjeta válido.")]
        [Display(Name = "Número de Tarjeta")]
        [MaxLength(16, ErrorMessage = "El número de tarjeta debe tener 16 caracteres de largo.")]
        [MinLength(16, ErrorMessage = "El número de tarjeta debe tener 16 caracteres de largo.")]
        public string NumeroTarjeta { get; set;}
        [Display(Name = "Titular")]
        public string TitularTarjeta { get; set; }
        [Display(Name = "Vencimiento")]
        public string VencimientoTarjeta { get; set; }
        [Display(Name = "Código de seguridad")]
        public int CodSeguridadTarjeta { get; set; }
        [Display(Name = "Monto")]
        public decimal MontoEfectivo { get; set; }
    }
}