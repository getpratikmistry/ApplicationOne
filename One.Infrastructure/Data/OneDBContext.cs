using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;

namespace One.Infrastructure.Data
{
    public class OneDBContext : DbContext
    {
        public OneDBContext(DbContextOptions<OneDBContext> options) : base(options)
        {

        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ExpenseItem> ExpenseItems { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
    }
}
