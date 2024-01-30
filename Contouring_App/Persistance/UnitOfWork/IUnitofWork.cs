using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;
using System.Collections.Generic;

namespace Contouring_App.Persistance.UnitOfWork
{
    public interface IUnitofWork : IDisposable
    {
        IAdminRepo admins { get; }
        IDevRepo devs { get; }
        IManagerRepo managers { get; }
        ITraineeRepo trainees { get; }
        IDivisionRepo divs { get; }
        IUserRepo users { get; }

        void SaveChanges();
    }
}
