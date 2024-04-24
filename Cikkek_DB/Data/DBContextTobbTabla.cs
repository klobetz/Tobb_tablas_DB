using Cikkek_DB.Model;
using Microsoft.EntityFrameworkCore;

namespace Cikkek_DB.Data
{
    public class DBContextTobbTabla:DbContext
    {
        public DBContextTobbTabla(DbContextOptions<DBContextTobbTabla> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
