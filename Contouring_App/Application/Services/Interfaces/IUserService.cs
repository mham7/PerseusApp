using Contouring_App.Application.Entities;

namespace Contouring_App.Application.Services.Interfaces
{
    public interface IUserService
    {
        public Usercs GetById(int id);
        public IEnumerable<Usercs> GetAll();
        public void Add(Usercs users);
        public void Update(Usercs users);
        public void Delete(Usercs users);
    }
}
