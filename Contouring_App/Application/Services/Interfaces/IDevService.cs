using Contouring_App.Application.Entities;

namespace Contouring_App.Application.Services.Interfaces
{
    public interface IDevService
    {
        public Dev GetById(int id);
        public IEnumerable<Dev> GetAll();
        public void Add(Dev dev);
        public void Update(Dev dev);
        public void Delete(Dev dev);
    }
}
