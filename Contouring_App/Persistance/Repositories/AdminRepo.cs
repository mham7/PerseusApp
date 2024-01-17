using Contouring_App.Application.Entities;
using Contouring_App.Persistance.Repositories.Interfaces;

namespace Contouring_App.Persistance.Repositories
{
    public class AdminRepo : IAdminRepo

    {
        public List<Admin> IsSalaryGreater(List<Admin> admins)
        {
            return admins.Where(admins => admins.Salary > 20000).ToList();
        }
    }
}
