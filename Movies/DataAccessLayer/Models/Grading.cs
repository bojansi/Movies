using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Modals
{
    public class Grading
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public int User_Id { get; set; }
        public int Movie_Id { get; set; }

    }
}
