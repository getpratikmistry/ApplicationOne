using One.Domain.Interfaces;
using One.Infrastructure.Data;

namespace One.Infrastructure.Repository
{
    public class UnitOfWork(OneDBContext context, IUserRepository _userRepository) : IUnitOfWork
    {
        private bool _disposed;
        public IUserRepository UserRepository => _userRepository;

        public async Task<int> CompleteAsync()
        {
            return await context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async ValueTask DisposeAsync()
        {
            await DisposeAsyncCore();
            Dispose(false);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                _disposed = true;
            }
        }

        protected virtual async ValueTask DisposeAsyncCore()
        {
            if (context is not null)
            {
                await context.DisposeAsync().ConfigureAwait(false);
            }
        }
    }
}
