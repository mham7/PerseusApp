using Contouring_App.Entities;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IUserRepo
    {
        List<Usercs> GetAuthenticatedUsers(List<Usercs> users);
    }
}
