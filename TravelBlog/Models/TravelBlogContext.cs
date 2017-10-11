using Microsoft.EntityFrameworkCore;

namespace TravelBlog.Models
{
	public class T : DbContext
	{
		public DbSet<City> Cities { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			=> optionsBuilder
				.UseMySql(@"Server=localhost;Port=8889;database=travelblog;uid=root;pwd=root;");
	}
}