using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces;
using One.Infrastructure.Data;

namespace One.Infrastructure.Repository
{
    public class UserRepository : Repository<UserDetail>, IUserRepository
    {
        private readonly OneDBContext _context;

        public UserRepository(OneDBContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<UserDetail>> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            return await _context.UserDetails.Where(e => e.Email == email).ToListAsync(cancellationToken);
        }
    }
}
