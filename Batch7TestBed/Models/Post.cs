using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Batch7TestBed.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public String Description { get; set; }

        public int Type { get; set; }

    }
}