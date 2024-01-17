using Contouring_App.Entities;
using Contouring_App.Persistance.Repositories.Interfaces;

namespace Contouring_App.Persistance.Repositories
{
    public class UserRepo : IUserRepo
    {
        List<Usercs> IUserRepo.GetAuthenticatedUsers(List<Usercs> users)
        {
            return users.Where(user => user.IsAuthenticated = true).ToList();
        }
    }
}
