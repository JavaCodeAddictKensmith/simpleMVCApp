using Vidly.Models;
using Microsoft.EntityFrameworkCore;


namespace Vidly.Data
{
	public class ApplicationDbContext: DbContext
	{
        //Category cat = new Category();
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options
			) : base(options)
        {

		}
		public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1, Name="Action", DisplayOrder=1},
                 new Category { Id = 1, Name = "SciFi", DisplayOrder = 2 },
                  new Category { Id = 1, Name = "History", DisplayOrder = 3 }

                );

        }
       

    }
}

