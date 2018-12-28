﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }


        //Remember leaving out the set makes this a readonly property

        //this is the short hand for setting a get or readonly propety
        public string DisplayText => SeriesTitle + " #" + IssueNumber;

        public string CoverImageFileName => SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
    }
}