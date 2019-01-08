using System.Web.Mvc;
using TreeHouseComicBooksGallery.Models;

namespace TreeHouseComicBooksGallery.Controllers
{
    public class ComicBookController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of" +
                                  " Doctor Octopus' life and his one, last, great act of revenge! " +
                                  "Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                   new Artist(){Name = "Dan Slott"       , Role = "Script" },
                   new Artist(){Name = "Humberto Ramos"  , Role = "Pencils"  },
                   new Artist(){Name = "Victor Olazab"   , Role = "Inks"     },
                   new Artist(){Name = "Edgar Delgado"   , Role = "Colors"   },
                   new Artist(){Name = "Chris Eliopoulos", Role = "Letters"  },
                }

             };

            return View(comicBook);

        }
    }
}
