using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.DAL;
using HospitalManagementSystem.Entities;

namespace HospitalManagementSystem.BLL
{
    public class UserService
    {
        private readonly UserRepository _userRepo = new UserRepository();

        public User Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and password are required.");
            }
            User user = _userRepo.GetUserByCredentials(username, password);
            if (user == null)
            {
                throw new ArgumentException("Invalid username or password.");
            }
            return user;
        }

        /*
         * public void RegisterUser(User user)
        {
            if (string.IsNullOrEmpty(user.Username) || string.IsNullOrEmpty(user.Password))
                throw new ArgumentException("Username and password are required.");

            _userRepo.AddUser(user);
        }
        */
    }
}
