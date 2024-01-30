using Contouring_App.Application.Entities;
using Contouring_App.Application.Entities.Dtos;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IDivisionRepo
    {
        public List<Divlist> Get_Divisions(int division);
    }
}
