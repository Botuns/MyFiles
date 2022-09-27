using Authentication.Contexts;
using Authentication.Entities;
using Authentication.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Authentication.Implementations.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _dbContext;
        public UserRepository(ApplicationContext context)
        {
            _dbContext = context;
        }
        public User Add(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
            return user;
        }

        public void Delete(int userId)
        {
            var user = FindById(userId);

            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }

        public User FindById(int userId)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(userId));
        }

        public List<User> GetAllUser(int userId)
        {
            return _dbContext.Users.Where(u => u.Id != 1 && u.Id != userId).ToList();
        }

        public User FindByEmail(string userEmail)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Email.Equals(userEmail));
        }


        public User Update(User user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
            return user;
        }

        public User FindByUsername(string username)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.UserName.Equals(username.ToLower()));
            return user;
        }
    }

}

