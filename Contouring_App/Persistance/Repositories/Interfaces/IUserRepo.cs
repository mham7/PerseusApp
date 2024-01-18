using Contouring_App.Application.Entities;
using Contouring_App.Application.Entities.Dtos;

namespace Contouring_App.Persistance.Repositories.Interfaces
{
    public interface IUserRepo
    {
        Usercs CheckAuthenticate(Userdto cred);
    }
}
