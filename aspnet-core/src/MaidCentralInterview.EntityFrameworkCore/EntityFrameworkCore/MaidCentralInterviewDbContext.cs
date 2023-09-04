using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MaidCentralInterview.Authorization.Roles;
using MaidCentralInterview.Authorization.Users;
using MaidCentralInterview.MultiTenancy;

namespace MaidCentralInterview.EntityFrameworkCore
{
    public class MaidCentralInterviewDbContext : AbpZeroDbContext<Tenant, Role, User, MaidCentralInterviewDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MaidCentralInterviewDbContext(DbContextOptions<MaidCentralInterviewDbContext> options)
            : base(options)
        {
        }
    }
}
