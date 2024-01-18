using Contouring_App.Application.Entities;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;

namespace Contouring_App.Application.Services
{
    public class DevService : IDevService
    {
        private readonly IUnitofWork _unit;
        private readonly IGenericRepo<Dev> _gen;

        public DevService(IGenericRepo<Dev> gen, IUnitofWork unit)
        {
            _unit = unit;
            _gen = gen;
        }
        public void Add(Dev dev)
        {
            _gen.Add(dev);
        }

        public void Delete(Dev dev)
        {
            _gen.Delete(dev);
        }

        public IEnumerable<Dev> GetAll()
        {
            return _gen.GetAll();
        }

        public Dev GetById(int id)
        {
            Dev dev = _gen.GetById(id);
            return dev;
        }

        public void Update(Dev dev)
        {
            _gen.Update(dev);
        }
    }
}
