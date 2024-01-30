using Contouring_App.Application.Entities;

namespace Contouring_App.Application.Services.Interfaces
{
    public interface IDivisionService
    {
        public Division GetById(int id);
        public IEnumerable<Division> GetAll();
        public void Add(Division division);
        public void Update(Division division);
        public void Delete(Division division);
    }
}
