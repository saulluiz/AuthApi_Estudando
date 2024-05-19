using ApiAuth.Models;
using System.Collections.Generic;
using System.Linq;

namespace ApiAuth.Repository
{
    public  class UserRepository
    {
        public static User Get(string username,string password)
        {
            var users = new List<User>();
            users.Add(new User
            {
                Id = "1",
                Username = "Saulo",
                Password = "Senha1",
                Role = "manager"
            }) ;users.Add(new User
            {
                Id = "2",
                Username = "Luiz",
                Password = "Senha2",
                Role = "employee"
            }) ;
            return users.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
        }
    }
}
