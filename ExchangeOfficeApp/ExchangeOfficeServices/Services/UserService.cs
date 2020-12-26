using ExchangeOfficeApp.Models;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using ExchangeOfficeServices.Services.Interfaces;
using ExchangeOfficeServices.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ExchangeOfficeServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void Add(string username, string password)
        {
            _userRepository.Add(username, PasswordEncription.HashPassword(password));
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public bool ValidateLogin(string username, string password)
        {
            return _userRepository.GetAllUsers().Any(u => username == u.Username && PasswordEncription.VerifyHashedPassword(u.Password, password));
        }

        
    }
}
