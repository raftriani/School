using School.Application.Intefaces;
using School.Domain.Entities;
using School.Domain.Repositories;

namespace School.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _UserRepository;

        public UserService(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task<IEnumerable<User>> FindAll()
        {
            return await _UserRepository.FindAll();
        }

        public async Task<User> GetById(int id)
        {
            return await _UserRepository.GetById(id);
        }

        public async Task<string> Add(User user)
        {
            await _UserRepository.Add(user);
            return string.Empty;
        }

        public async Task<string> Update(User user)
        {
            var fromDb = await FindOriginalUser(user);
            await _UserRepository.Update(fromDb);
            return string.Empty;
        }

        public async Task Delete(int id)
        {
            await _UserRepository.Remove(id);
        }

        private async Task<User> FindOriginalUser(User User)
        {
            var fromDb = await GetById(User.Id);
            fromDb.Name = !string.IsNullOrEmpty(User.Name) ? User.Name : fromDb.Name;
            fromDb.Surname = !string.IsNullOrEmpty(User.Surname) ? User.Surname : fromDb.Surname;
            fromDb.Email = !string.IsNullOrEmpty(User.Email) ? User.Email : fromDb.Email;

            return fromDb;
        }
    }
}
