using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2.Models
{
    public class Transporte
    {
        public string destinatario { get; set; }
        public string[] destino { get; set; }
        public List<SelectListItem> destinos { get; set; }
        public double tarifa { get; set; }
        public double tm { get; set; }

        public Transporte()
        {
            tm = 0;
            tarifa = 150;
        }

        public double Flete()
        {
            return tm * tarifa;
        }
    }
}