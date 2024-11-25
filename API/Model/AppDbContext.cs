using Microsoft.EntityFrameworkCore;

namespace API.Model
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<SinhVien> sinhViens { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
			optionsBuilder.UseSqlServer("Server=.;Database=Demo;Trusted_Connection=True; TrustServerCertificate=true");
		}
	}
}
