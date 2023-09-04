using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MaidCentralInterview.EntityFrameworkCore
{
    public static class MaidCentralInterviewDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MaidCentralInterviewDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MaidCentralInterviewDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
