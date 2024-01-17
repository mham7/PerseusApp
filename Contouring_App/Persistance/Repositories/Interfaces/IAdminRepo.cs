using Contouring_App.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IAdminRepo
    {
        public List<Admin> IsSalaryGreater(List<Admin> admins);
    }
}
