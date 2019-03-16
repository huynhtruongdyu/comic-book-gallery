using ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHTML = "<p>Hello <i>aasdfas</i></p>",
                Artists = new Artist[]
                {
                    new Artist(){ Name="Duy Huynh", Role="Script"},
                    new Artist(){ Name="Duy Huynh", Role="Pencils"},
                    new Artist(){ Name="Duy Huynh", Role="Inks"},
                    new Artist(){ Name="Duy Huynh", Role="Color"},
                    new Artist(){ Name="Duy Huynh", Role="Letters"}
                }
            };
            return View(comicBook);
        }
    }
}