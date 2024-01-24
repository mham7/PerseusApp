using Contouring_App.Application.Entities;
using Contouring_App.Persistance.Context;
using Contouring_App.Persistance.Repositories.Interfaces;

namespace Contouring_App.Persistance.Repositories
{
    public class AdminRepo : IAdminRepo
    {
        private readonly AppDbContext _context;
        public AdminRepo(AppDbContext context) {
            _context= context;
        }
        public List<Admin> IsSalaryGreater(int count) 
        {
            return _context.Admin.Where(admins => admins.Salary >count).ToList();
        }
    }
}
