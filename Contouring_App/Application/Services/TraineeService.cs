using Contouring_App.Application.Entities;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;

namespace Contouring_App.Application.Services
{
    public class TraineeService : ITraineeService
    {
        private readonly IUnitofWork _unit;
        private readonly IGenericRepo<Trainee> _gen;
        public TraineeService(IUnitofWork unit, IGenericRepo<Trainee> gen)
        {
            _unit = unit;
            _gen = gen;
        }
        public void Add(Trainee trainee)
        {
            _gen.Add(trainee);
        }

        public void Delete(Trainee trainee)
        {
            _gen.Delete(trainee);
        }

        public IEnumerable<Trainee> GetAll()
        {
            return _gen.GetAll();
        }

        public Trainee GetById(int id)
        {
            return _gen.GetById(id);
        }

        public void Update(Trainee trainee)
        {
             _gen.Update(trainee);
        }
    }
}
