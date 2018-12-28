using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicGallery.Controllers
{
    public class ComicGalleryController : Controller
    {
        // GET: ComicGallery
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing SpiderMan";
            ViewBag.IssueNum = 700;
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };
            ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' " +
                        "life and his one, last, great act of revenge! Even if Spider-Man survives... " +
                        "<strong>will Peter Parker?</strong></p>";

            return View();
        }
    }
}