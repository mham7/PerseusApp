using Contouring_App.Application.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IDevRepo
    {
        public List<Dev> GetStackList(string techstack);
    }
}
