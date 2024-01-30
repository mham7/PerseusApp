using Contouring_App.Application.Entities;
using Contouring_App.Application.Services.Interfaces;
using Contouring_App.Persistance.Repositories.Interfaces;
using Contouring_App.Persistance.UnitOfWork;

namespace Contouring_App.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUnitofWork _unit;
        private readonly IGenericRepo<Admin> _gen;

        public AdminService(IGenericRepo<Admin> gen,IUnitofWork unit)
        {
            _unit= unit;
            _gen= gen;
        }
        public void Add(Admin admin)
        {
            _gen.Add(admin);    
        }

        public void Delete(Admin admin)
        {
            _gen.Delete(admin);
        }

        public IEnumerable<Admin> GetAll()
        {
           return _gen.GetAll();
        }

        public  Admin GetById(int id)
        {
            Admin admin = _gen.GetById(id);
            return admin;
        }

        public List<Admin> IsSalaryGreater(List<Admin> admins)
        {
            return _unit.admins.IsSalaryGreater(admins);

        }

        public void Update(Admin admin)
        {
            _gen.Update(admin);
        }
    }
}
