using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2.Models
{
    public class Leonidas : Transporte
    {
        public double Tarifario()
        {
            switch (destino[0].ToLower())
            {
                case "arequipa":
                case "ilo":
                case "tacna":
                    tarifa = 200;
                    break;
                case "piura":
                case "tumbes":
                    tarifa = 220;
                    break;
                default:
                    tarifa = 150;
                    break;
            }
            return tarifa;
        }

        public double Seguro()
        {
            return 0.05 * Flete();
        }

        public double Monto()
        {
            return Flete() + Seguro();
        }

        public List<SelectListItem> getDestinos()
        {
            List<SelectListItem> destinoList = new List<SelectListItem>();
            destinoList.Add(new SelectListItem { Text = "Arequipa", Value = "Arequipa" });
            destinoList.Add(new SelectListItem { Text = "Ica", Value = "Ica" });
            destinoList.Add(new SelectListItem { Text = "Tumbes", Value = "Tumbes" });
            destinoList.Add(new SelectListItem { Text = "Piura", Value = "Piura" });
            destinoList.Add(new SelectListItem { Text = "Ilo", Value = "Ilo" });
            destinoList.Add(new SelectListItem { Text = "Tacna", Value = "Tacna" });
            destinoList.Add(new SelectListItem { Text = "Huancayo", Value = "Huancayo" });
            return destinoList;
        }
    }
}