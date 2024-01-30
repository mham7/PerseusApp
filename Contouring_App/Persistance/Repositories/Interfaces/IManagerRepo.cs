
using Contouring_App.Application.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IManagerRepo
    {
        public List<string> getCommonDivisions(Manager manager); 
    }
}
