using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CrudAbp.EntityFrameworkCore
{
    public static class CrudAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CrudAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CrudAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
