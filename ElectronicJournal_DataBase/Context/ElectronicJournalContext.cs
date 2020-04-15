using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using ElectronicJournal_DataBase.Context.Configurations;
using ElectronicJournal_DataBase.Context.InitializationData;
namespace ElectronicJournal_DataBase.Context
{
	public class ElectronicJournalContext :DbContext 
	{
		public DbSet<User> Users { get; set; }
		public DbSet<AccessLevel> AccessLevels { get; set; }

		public ElectronicJournalContext()
		{
			Database.EnsureDeleted();   // удаляем бд со старой схемой
			Database.EnsureCreated();   // создаем бд с новой схемой
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ElectronicJournal_DataBase;Trusted_Connection=True;");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// использование Fluent API
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new AccessLevelConfiguration());

			modelBuilder.Entity<AccessLevel>().HasData(new Initialization_AccessLevel().Initialization);
			modelBuilder.Entity<User>().HasData(new Initialization_User().Initialization);
			

		}
	}

}
