using ComicGallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man!",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' " +
                        "life and his one, last, great act of revenge! Even if Spider-Man survives... " +
                        "<strong>will Peter Parker?</strong></p>",
                Artists = new Artists[]
                {
                    new Artists() {Name = "Dan Slott", Role = "Script"},
                    new Artists() {Name = "Humberto Ramos", Role = "Pencils"},
                    new Artists() {Name = "Victor Olazaba", Role = "Inks"},
                    new Artists() {Name = "Edgar Delgado", Role = "Colors"},
                    new Artists() {Name = "Chris Eliopoulos", Role = "Letters"}
                }
            };
            // =========================================================================================================================================

            //WHEN USING VIEWBAG

            //ViewBag.SeriesTitle = "The Amazing SpiderMan";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};
            //ViewBag.Description = "<p>Final issue! Witness the final hours of Doctor Octopus' " +
            //            "life and his one, last, great act of revenge! Even if Spider-Man survives... " +
            //            "<strong>will Peter Parker?</strong></p>";
            // =========================================================================================================================================


            //send the comicBook var to the view to be displayed
            return View(comicBook);
        }
    }
}