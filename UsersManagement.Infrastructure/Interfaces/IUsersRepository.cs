using UsersManagement.Application.Models;

namespace UsersManagement.Infrastructure.Interfaces;

public interface IUsersRepository : IBaseRepository<UserModel>, IDisposable
{
    
}