using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Domain.Interfaces
{
    public interface IUserRepository : IRepository<UserDetail>
    {
        Task<IEnumerable<UserDetail>> GetUserByEmailAsync(string email, CancellationToken cancellationToken = default);
    }
}
