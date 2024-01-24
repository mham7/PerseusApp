using Contouring_App.Application.Entities;
using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;

namespace Contouring_App.Persistance.Repositories
{
    public class TraineeRepo : ITraineeRepo
    {
        private AppDbContext _dbContext;

        public TraineeRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Trainee> GetTraineeswithMinWage(int salary)
        {
          IQueryable<Trainee> s= _dbContext.Trainee.Where(s=>s.Salary>salary);
            return s.ToList();
        }
    }
}
