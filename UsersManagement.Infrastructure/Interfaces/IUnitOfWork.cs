namespace UsersManagement.Infrastructure.Interfaces;

public interface IUnitOfWork
{
    IUsersRepository Users { get; }
}