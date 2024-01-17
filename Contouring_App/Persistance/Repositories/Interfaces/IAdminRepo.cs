using Contouring_App.Application.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IAdminRepo
    {
        public List<Admin> IsSalaryGreater(List<Admin> admins);
    }
}
