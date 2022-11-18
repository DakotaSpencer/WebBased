using Microsoft.EntityFrameworkCore;
using Galleria.Models;

namespace Galleria.Data
{
    public class CommissionContext : DbContext
    {
        public CommissionContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Commission> Commissions { get; set; }
    }
}
