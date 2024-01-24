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

            IQueryable<Usercs> cs = _appDbContext.Users.Where(user => user.Email == cred.email);

            Usercs found_user = cs.First();

            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(cred.password, found_user.Password);

            if (found_user != null && isPasswordValid==true)
            {
                return found_user;
            }
            else
            {
                return null;
            }
        }

        
    }
}
