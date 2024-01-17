
using Contouring_App.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IManagerRepo
    {
        public List<string> getCommonDivisions(Manager manager); 
    }
}
