﻿using System;
using System.Linq;
using System.Web.Mvc;
using TreeHouseComicBooksGallery.Data;
using TreeHouseComicBooksGallery.Models;

namespace TreeHouseComicBooksGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }


        public ActionResult Index()
        {

            var comicBooks = _comicBookRepository.GetComicBooks();

            return View(comicBooks);
        }


        public ActionResult Detail(int? id)
        {
            if (id == null)  return HttpNotFound();

            var comicBook = _comicBookRepository.GetComicBook((int) id);

            return comicBook == null ? (ActionResult) HttpNotFound() : View(comicBook);
        }
    }
}
