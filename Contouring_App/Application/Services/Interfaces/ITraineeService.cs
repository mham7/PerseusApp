
using Contouring_App.Application.Entities;

namespace Contouring_App.Application.Services.Interfaces
{
    public interface ITraineeService
    {

        public Trainee GetById(int id);
        public IEnumerable<Trainee> GetAll();
        public void Add(Trainee trainee);
        public void Update(Trainee trainee);
        public void Delete(Trainee trainee);
    }
}
