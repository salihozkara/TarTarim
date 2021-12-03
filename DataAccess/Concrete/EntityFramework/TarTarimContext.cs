using CoreLayer.Utilities.IoC;
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
            var conStr = _configuration.GetConnectionString("TarTarimDb");
            optionsBuilder.UseSqlServer(conStr);
        }
    }
}
