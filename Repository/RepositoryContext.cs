using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {    
        }
        public DbSet<Company>? Companys { get; set; }

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Company>().HasKey(x=>x._id);
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CompanyConfiguration());
        }
    }
}