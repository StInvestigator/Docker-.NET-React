using Microsoft.EntityFrameworkCore;
using React_DNET.Server.Model;

namespace React_DNET.Server.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
    }
}
