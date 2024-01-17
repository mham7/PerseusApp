using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;

namespace Contouring_App.Persistance.UnitOfWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext _appcontext;

        public IAdminRepo admins { get; }

        public IDevRepo devs { get; }

        public IManagerRepo managers { get; }

        public ITraineeRepo trainees { get; }

        public IDivisionRepo divs { get; }

        public IUserRepo users { get; }
        public UnitofWork(AppDbContext appcontext, IAdminRepo adminrepo,
         IDevRepo devrepo, IManagerRepo managerrepo,ITraineeRepo traineerepo, IDivisionRepo divrepo)
        {
            _appcontext = appcontext;
            admins = adminrepo;
            devs=devrepo;
            managers = managerrepo;
            trainees = traineerepo;
            divs = divrepo;
        }
       

        public void Dispose()
        {
            _appcontext.Dispose();
        }

        public void SaveChanges()
        {
            _appcontext.SaveChanges();
        }
    }
}
