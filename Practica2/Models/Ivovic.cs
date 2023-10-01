using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practica2.Models
{
    public class Ivovic : Transporte
    {
        public string cliente { get; set; }

        public List<SelectListItem> getDestinos()
        {
            List<SelectListItem> destinoList = new List<SelectListItem>();
            destinoList.Add(new SelectListItem { Text = "Arequipa", Value = "Arequipa" });
            destinoList.Add(new SelectListItem { Text = "Piura", Value = "Piura" });
            destinoList.Add(new SelectListItem { Text = "Cusco", Value = "Cusco" });
            destinoList.Add(new SelectListItem { Text = "Cajamarca", Value = "Cajamarca" });
            destinoList.Add(new SelectListItem { Text = "Puno", Value = "Puno" });
            destinoList.Add(new SelectListItem { Text = "Ayacucho", Value = "Ayacucho" });
            destinoList.Add(new SelectListItem { Text = "Loreto", Value = "Loreto" });
            return destinoList;
        }
    }
}