using Contouring_App.Application.Entities;
using Contouring_App.Application.Entities.Dtos;
using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Contouring_App.Persistance.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly AppDbContext _appDbContext;
        public UserRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public Usercs CheckAuthenticate(Userdto cred)
        {
            HashSet<Usercs> users= new HashSet<Usercs>();

            users = _appDbContext.Users.ToHashSet();

            bool val=users.Any(user => user.Email == cred.email);

            Usercs foundUser = users.FirstOrDefault(user => user.Email == cred.email);

            if (foundUser != null)
            {
                return foundUser;
            }
            else
            {
                return null;
            }
        }

        
    }
}
