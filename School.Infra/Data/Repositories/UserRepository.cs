using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Domain.Repositories;

namespace School.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly SchoolContext _context;

        public UserRepository(SchoolContext cashierContext)
        {
            _context = cashierContext;
        }

        public async Task<User> GetUser()
        {
            // Como existe apenas uma conta no exemplo, será feito dessa forma
            return await _context.User.FirstAsync();
        }

        public virtual async Task<IEnumerable<User>> FindAll()
        {
            return await _context.User.ToListAsync();
        }

        public virtual async Task<User> GetById(int id)
        {
            return await _context.User.FindAsync(id);
        }
        public virtual async Task Add(User User)
        {
            _context.User.Add(User);
            await SaveChanges();
        }

        public virtual async Task Update(User User)
        {
            _context.User.Update(User);
            await SaveChanges();
        }

        public virtual async Task Remove(int id)
        {
            //_context.User.Remove(new User { Id = id });
            await SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<int> SaveChanges()
        {
            var result = await _context.SaveChangesAsync();

            return result;
        }
    }
}
