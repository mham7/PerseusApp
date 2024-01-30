using Contouring_App.Application.Entities;
using Contouring_App.Persistance.UnitOfWork;
using System;

namespace Contouring_App.Application.Services.Interfaces
{
    public interface IAdminService 
    {

        public Admin GetById(int id);
        public IEnumerable<Admin> GetAll();
        public void Add(Admin admin);
        public void Update(Admin admin);
        public void Delete(Admin admin);
        public List<Admin> IsSalaryGreater(int salary);


    }
}
