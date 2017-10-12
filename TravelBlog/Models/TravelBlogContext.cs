using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
    public class TravelBlogContext : DbContext
    {
        public TravelBlogContext()
        {
        }

		public DbSet<Location> Locations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<People> People { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
				.UseMySql(@"Server=localhost;Port=8889;database=travelblog;uid=root;pwd=root;");
        }

		public TravelBlogContext(DbContextOptions<TravelBlogContext> options)
            : base(options)
        {
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}