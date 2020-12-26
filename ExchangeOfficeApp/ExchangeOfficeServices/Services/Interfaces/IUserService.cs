using ExchangeOfficeApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExchangeOfficeServices.Services.Interfaces
{
    public interface IUserService
    {
        public void Add(string username, string password);
        public IEnumerable<User> GetAllUsers();
    }
}
