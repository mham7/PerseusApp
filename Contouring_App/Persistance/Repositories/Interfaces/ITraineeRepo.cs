using Contouring_App.Application.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface ITraineeRepo
    {
        public List<Trainee> GetTraineeswithMinWage(int salary);


    }
}
