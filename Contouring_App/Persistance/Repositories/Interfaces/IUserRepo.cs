using Contouring_App.Application.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IUserRepo
    {
        List<Usercs> GetAuthenticatedUsers(List<Usercs> users);
    }
}
