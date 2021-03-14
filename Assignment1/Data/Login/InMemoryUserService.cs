using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1.Data.Login
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users = new List<User>();

        private User first = new User()
        {
            Username = "bogdan",
            Password = "12345",
            Age = 20,
            SecurityLvl = 5
        };

        public InMemoryUserService()
        {
            users.Add(first);
        }
        
        public User ValidateUser(string Username, string Password)
        {
            var user = users.FirstOrDefault(user => user.Username.Equals(Username));

            if (user == null)
            {
                throw new Exception("User not found");
            }

            if (!user.Password.Equals(Password))
            {
                throw new Exception("Incorrect password");
            }

            return user;
        }
    }
}