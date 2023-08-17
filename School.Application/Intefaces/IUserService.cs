using School.Domain.Entities;

namespace School.Application.Intefaces
{
    public interface IUserService
    {
        Task<IEnumerable<User>> FindAll();
        Task<User> GetById(int id);
        Task<string> Add(User user);
        Task<string> Update(User user);
        Task Delete(int id);
    }
}
