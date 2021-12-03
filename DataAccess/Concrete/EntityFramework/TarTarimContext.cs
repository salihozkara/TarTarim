using CoreLayer.Entities.Concrete;
using CoreLayer.Utilities.IoC;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class TarTarimContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public TarTarimContext()
        {
            _configuration = ServiceTool.ServiceProvider.GetService<IConfiguration>();
        }
        
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var conStr = _configuration.GetConnectionString("TarTarimDb");
            var conStr = @"server=(localdb)\MSSQLLocalDB; database=TarTarimDb; integrated security=true;MultipleActiveResultSets=True;";
            optionsBuilder.UseSqlServer(conStr);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Answer>()
                .HasOne(e => e.User)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction); // <--
            modelBuilder.Entity<ReplyAnswer>()
                .HasOne(e => e.Answer)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<ReplyAnswer>()
                .HasOne(e => e.User)
                .WithMany()
                .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<AgriculturalEngineer> AgriculturalEngineers { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
        public DbSet<QuestionSubCategory> QuestionSubCategories { get; set; }
        public DbSet<ReplyAnswer> ReplyAnswers { get; set; }
        public DbSet<TruckDriver> TruckDrivers { get; set; }
        public DbSet<Veterinary> Veterinaries { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
