using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace comic_book_gallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.seriesTitle = "The amazing spiderman";
            ViewBag.issuenumber = 700;
            ViewBag.description = "<p> Final issue! Witness the final hour</p>";
            ViewBag.artists = new string[]
        {

            "Script: Dan Slott",
            "Pencils: Humberto Ramos",
            "Inks: Victoria Olazaba",
            "Colors: Edgar Delgado",
            "Letters: Chris Eliopoulos"
        };
            return View();
        }

    }
}