using Contouring_App.Application.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface ITraineeRepo
    {
        List<Trainee> GetTraineesTenure(int year);
        
    }
}
