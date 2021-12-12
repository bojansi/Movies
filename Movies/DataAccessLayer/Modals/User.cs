using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Modals
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }

    }
}
