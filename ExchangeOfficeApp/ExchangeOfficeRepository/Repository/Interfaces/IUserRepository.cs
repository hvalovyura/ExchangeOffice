using ExchangeOfficeApp.Models;
using ExchangeOfficeRepository.Repository.Interfaces.General;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeOfficeRepository.Repository.Interfaces
{
    public interface IUserRepository : IRepository
    {
        public IEnumerable<User> GetAllUsers();
    }
}
