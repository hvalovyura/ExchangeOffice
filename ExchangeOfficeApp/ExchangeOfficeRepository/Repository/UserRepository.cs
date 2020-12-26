using ExchangeOfficeApp.Models;
using ExchangeOfficeApp.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExchangeOfficeRepository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _db;

        public UserRepository()
        {
            _db = new AppDBContext();
            _db.Users.Load();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _db.Users.Any() ? _db.Users.OrderBy(u => u.Id) : null;
        }

        public void Add(string username, string password)
        {
            var user = new User
            {
                Username = username,
                Password = password
            };
            _db.Add(user);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}
