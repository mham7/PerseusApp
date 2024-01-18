using Contouring_App.Application.Entities;
using Contouring_App.Application.Entities.Dtos;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;
using BCrypt.Net;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;

namespace Contouring_App.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUnitofWork _unit;
        private readonly IConfiguration _config;
        private readonly IGenericRepo<Usercs> _gen;
        public UserService(IUnitofWork unit, IGenericRepo<Usercs> gen, IConfiguration config)
        {
            _unit = unit;
            _gen = gen;
            _config = config;   
        }
        public void Add(Usercs users)
        {
            _gen.Add(users);
        }

        public void Delete(Usercs users)
        {
            _gen.Delete(users);
        }

        public IEnumerable<Usercs> GetAll()
        {
            return _gen.GetAll();
        }

        public Usercs GetById(int id)
        {
            return _gen.GetById(id);
        }

        public string Login(Userdto user)
        {
            user.password= BCrypt.Net.BCrypt.HashPassword(user.password);
            Usercs authuser =_unit.users.CheckAuthenticate(user);
            if(authuser == null) {

                return "Not Authenicated";
            }
            return Tokenization(authuser);

        }

        public Userdto Register(Usercs user)
        {
            string password = user.Password;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            user.Password=hashedPassword;
            _gen.Add(user);
            Userdto userdto = new Userdto();
            userdto.password=hashedPassword;
            userdto.email=user.Email;

            return userdto;

        }

        public string Tokenization(Usercs user)
        {

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,user.Name),
                new Claim(ClaimTypes.Role,user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("JWT:SecretKey").Value!));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );

            string jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }

      

        public void Update(Usercs users)
        {
            _gen.Update(users);
        }
    }
}
