using DataAccessLayer;
using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogicLayer
{
    public class UserBusiness
    {
        private readonly UserRepository userRepository;
        public UserBusiness()
        {
            this.userRepository = new UserRepository();
        }

        public List<User> GetAllUsers()
        {
            return this.userRepository.GetAllUsers();
        }
        public bool InsertUser(User u)
        {
            if (this.userRepository.InsertUser(u) > 0)
            {
                return true;
            }
            return false;
        }

        public bool UpdateUser(User u)
        {
            if (this.userRepository.UpdateUser(u) > 0)
            {
                return true;
            }
            return false;
        }

        public bool DeleteUser(int Id)
        {
            if (this.userRepository.DeleteUser(Id) > 0)
            {
                return true;
            }
            return false;
        }

        public bool GetUserForLogin(String username, String password)
        {
            User user = this.userRepository.GetAllUsers().FirstOrDefault(u => u.UserName == username && u.Password == password);

            if(user != null)
            {
                return true;
            }
            return false;
        }
    }
}
