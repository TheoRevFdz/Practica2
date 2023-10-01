using Practica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;
using SelectListItem = System.Web.Mvc.SelectListItem;

namespace Practica2.Controllers
{
    public class SolucionController : Controller
    {
        // GET: Ivovic
        public ActionResult GuiaTransporte()
        {
            Ivovic ivovic = new Ivovic();
            ivovic.destinos = ivovic.getDestinos();
            return View(ivovic);
        }

        [HttpPost]
        public ActionResult GuiaTransporte(Ivovic ivovic)
        {
            ivovic.destinos = ivovic.getDestinos();
            ViewBag.flete = ivovic.Flete().ToString("#####.#0");
            return View(ivovic);
        }

        public ActionResult GuiaLeonidas()
        {
            Leonidas leonidas = new Leonidas();
            leonidas.destinos = leonidas.getDestinos();
            return View(leonidas);
        }

        [HttpPost]
        public ActionResult GuiaLeonidas(Leonidas l)
        {
            l.destinos = l.getDestinos();
            String format = "#####.#0";
            ViewBag.flete = l.Flete().ToString(format);
            ViewBag.seguro = l.Seguro().ToString(format);
            ViewBag.monto = l.Monto().ToString(format);
            return View(l);
        }
    }
}