using Contouring_App.Application.Entities;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;

namespace Contouring_App.Application.Services
{
    public class DivisionService : IDivisionService
    {
        private readonly IGenericRepo<Division> _gen;
        private readonly IUnitofWork _unit;

        public DivisionService(IUnitofWork unit, IGenericRepo<Division> gen)
        {
            _gen = gen;
            _unit = unit;
        }
        public void Add(Division division)
        {
            _gen.Add(division);
        }

        public void Delete(Division division)
        {
            _gen.Delete(division);
        }

        public IEnumerable<Division> GetAll()
        {
            return _gen.GetAll();
        }

        public Division GetById(int id)
        {
            return _gen.GetById(id);
        }

        public void Update(Division division)
        {
            _gen.Update(division);
        }
    }
}
