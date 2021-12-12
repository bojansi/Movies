using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Modals
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Year { get; set; }
        public String Genre { get; set; }
        public Boolean Favorite { get; set; }
        public String IMDBLink { get; set; }
        public String Description { get; set; }
    }
}
