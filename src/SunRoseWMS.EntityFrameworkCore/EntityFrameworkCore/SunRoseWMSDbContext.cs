using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SunRoseWMS.Authorization.Roles;
using SunRoseWMS.Authorization.Users;
using SunRoseWMS.MultiTenancy;

namespace SunRoseWMS.EntityFrameworkCore
{
    public class SunRoseWMSDbContext : AbpZeroDbContext<Tenant, Role, User, SunRoseWMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public SunRoseWMSDbContext(DbContextOptions<SunRoseWMSDbContext> options)
            : base(options)
        {
        }
    }
}
