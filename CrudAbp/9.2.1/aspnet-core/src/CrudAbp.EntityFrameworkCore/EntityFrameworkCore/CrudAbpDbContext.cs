using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CrudAbp.Authorization.Roles;
using CrudAbp.Authorization.Users;
using CrudAbp.MultiTenancy;

namespace CrudAbp.EntityFrameworkCore
{
    public class CrudAbpDbContext : AbpZeroDbContext<Tenant, Role, User, CrudAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Table.CrudTable> CrudTable { get; set; }
        public CrudAbpDbContext(DbContextOptions<CrudAbpDbContext> options)
            : base(options)
        {
        }
    }
}
