namespace UsersManagement.Infrastructure.Interfaces;

public interface IBaseRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();        
    Task<T> GetById(int customerId);        
    Task<object> Add(T customer);        
    Task<int> Delete(int customerId);        
    Task<int> Update(T customer);
}