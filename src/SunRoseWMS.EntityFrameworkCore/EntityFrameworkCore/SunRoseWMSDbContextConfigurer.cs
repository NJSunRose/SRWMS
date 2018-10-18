using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SunRoseWMS.EntityFrameworkCore
{
    public static class SunRoseWMSDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SunRoseWMSDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SunRoseWMSDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
