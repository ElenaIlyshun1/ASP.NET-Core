﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPhone.Main.Models
{
    public class VideoCardCategory
    {
        public int Id { set; get; }
        public string categoryName { get; set; }
        public string categoryDescription { get; set; }
        public List<VideoCard> videoCards { set; get; }
    }
}
