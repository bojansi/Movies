using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Modals
{
    public class Grading
    {
        public int Id { get; set; }
        public decimal Rating { get; set; }
        public User User_Id { get; set; }
        public Movie Movie_Id { get; set; }

    }
}
