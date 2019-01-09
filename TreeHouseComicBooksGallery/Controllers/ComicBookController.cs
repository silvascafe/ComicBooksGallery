using System;
using System.Linq;
using System.Web.Mvc;
using TreeHouseComicBooksGallery.Data;
using TreeHouseComicBooksGallery.Models;

namespace TreeHouseComicBooksGallery.Controllers
{
    public class ComicBookController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Detail(int id)
        {
            var comicBookRepository = new ComicBookRepository();
            var comicBook = comicBookRepository.GetComicBook(id);

            if(comicBook != null)
              return View(comicBookRepository.GetComicBook(id));

            return Redirect("/");
        }
    }
}
