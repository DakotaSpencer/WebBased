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
        public DbSet<User> Users { get; set; }
        public DbSet<CommissionImageModel> CommissionImages { get; set; }
        public DbSet<UserProfilePicture> UserProfilePictures { get; set; }

    }
}
