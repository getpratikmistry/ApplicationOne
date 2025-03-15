using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable, IAsyncDisposable
    {
        public IUserRepository UserRepository { get; }
        Task<int> CompleteAsync();
    }
}
