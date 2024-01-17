using Contouring_App.Application.Entities;

namespace Contouring_App.Application.Services.Interfaces
{
    public interface IManagerService
    {

        public Manager GetById(int id);
        public IEnumerable<Manager> GetAll();
        public void Add(Manager manager);
        public void Update(Manager manager);
        public void Delete(Manager manager);
    }
}
