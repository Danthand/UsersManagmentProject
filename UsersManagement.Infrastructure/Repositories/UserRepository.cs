using System.Data.SqlClient;
using Dommel;
using Microsoft.Extensions.Configuration;
using UsersManagement.Application.Models;
using UsersManagement.Infrastructure.Interfaces;

namespace UsersManagement.Infrastructure.Repositories;

public class UserRepository : IUsersRepository
{
    private readonly SqlConnection _sqlConnection;
    
    public UserRepository(IConfiguration configuration)
    {
        _sqlConnection = new SqlConnection(configuration.GetConnectionString("LocalDatabase"));
    }
    
    public Task<IEnumerable<UserModel>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<UserModel> GetById(int customerId)
    {
        throw new NotImplementedException();
    }

    public async Task<object> Add(UserModel customer)
    {
        return await _sqlConnection.InsertAsync(customer);
    }

    public Task<int> Delete(int customerId)
    {
        throw new NotImplementedException();
    }

    public Task<int> Update(UserModel customer)
    {
        throw new NotImplementedException();
    }

    public async void Dispose()
    {
        await _sqlConnection.DisposeAsync();
    }
}