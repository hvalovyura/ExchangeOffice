using ExchangeOfficeApp.Models;
using ExchangeOfficeRepository.Repository;
using ExchangeOfficeRepository.Repository.Interfaces;
using ExchangeOfficeServices.Services.Interfaces;
using System;
using System.Collections.Generic;
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
            _userRepository.Add(username, password);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
    }
}
