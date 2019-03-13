using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {

            ViewBag.seriesTitle = "The Amazing Spider-Man";
            ViewBag.issueNumber = 700;
            ViewBag.description = "<p>Hello <i>aasdfas</i></p>";
            ViewBag.artists = new string[]
            {
        "Script: Duy Huynh",
        "Pencils: Duy Huynh",
        "Inks: Duy huynh",
        "Color: Duy huynh",
        "Letters: Duy huynh"
            };
            return View();
        }
    }
}