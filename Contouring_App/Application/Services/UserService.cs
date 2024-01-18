using Contouring_App.Application.Entities;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;

namespace Contouring_App.Application.Services
{
    public class UserService : IUserService
    {

        private readonly IUnitofWork _unit;
        private readonly IGenericRepo<Usercs> _gen;
        public UserService(IUnitofWork unit, IGenericRepo<Usercs> gen)
        {
            _unit = unit;
            _gen = gen;
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

        public void Update(Usercs users)
        {
            _gen.Update(users);
        }
    }
}
