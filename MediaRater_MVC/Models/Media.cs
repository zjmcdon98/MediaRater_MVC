using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediaRater_MVC.Models
{
    public class Media
    {
        public int MediaID { get; set; }
        public string Name { get; set; }
        public string MediaType { get; set; }
        public string Rating { get; set; }
    }

    public class MediaDBContext : DbContext
    {
        public DbSet<Media> Media { get; set; }
    }
}