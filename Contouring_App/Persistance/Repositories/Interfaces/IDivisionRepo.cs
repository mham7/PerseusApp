using Contouring_App.Application.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IDivisionRepo
    {
        public List<Division> GetNum_Divisions(string division);
    }
}
