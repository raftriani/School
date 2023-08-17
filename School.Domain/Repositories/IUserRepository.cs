using School.Domain.Entities;
using School.Domain.Repositories.Base;

namespace School.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<IEnumerable<User>> FindAll();
        Task<User> GetById(int id);
        Task Add(User user);
        Task Update(User user);
        Task Remove(int id);
    }
}
