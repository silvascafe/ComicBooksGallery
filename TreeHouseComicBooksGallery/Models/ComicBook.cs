﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TreeHouseComicBooksGallery.Models
{
    public class ComicBook
    {
        public bool Favorite { get; set; }

        public int Id { get; set; }

        public string SeriesTitle { get; set; }

        public int IssueNumber { get; set; }

        public string DescriptionHtml { get; set; }

        public Artist[] Artists { get; set; }

        public string DisplayText => $"{SeriesTitle} # {IssueNumber}";

        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                           .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}