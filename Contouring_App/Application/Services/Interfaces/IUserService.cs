using Contouring_App.Application.Entities;
using Contouring_App.Application.Entities.Dtos;

namespace Contouring_App.Application.Services.Interfaces
{
    public interface IUserService
    {
        public Usercs GetById(int id);
        public IEnumerable<Usercs> GetAll();
        public string Login(Userdto user);
        public Userdto Register(Usercs user);
        public void Add(Usercs users);
        public string Tokenization(Usercs user);
        public void Update(Usercs users);
        public void Delete(Usercs users);
    }
}
