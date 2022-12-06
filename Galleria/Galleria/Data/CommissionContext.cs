using Microsoft.EntityFrameworkCore;
using Galleria.Models;

namespace Galleria.Data
{
    public class CommissionContext : DbContext
    {
        public CommissionContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<CommissionModel> Commissions { get; set; }
        public DbSet<UserModel> Users { get; set; }

        public static implicit operator CommissionContext(CommissionDAL v)
        {
            throw new NotImplementedException();
        }
    }
}
