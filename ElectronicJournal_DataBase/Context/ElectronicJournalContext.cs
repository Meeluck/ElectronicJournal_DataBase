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
		public DbSet<Group> Groups { get; set; }
		public DbSet<StudentGroup> StudentGroups { get; set; }
		public DbSet<Position> Positions { get; set; }
		public DbSet<Teacher> Teachers { get; set; }
		
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


			#region Model Configuration
			/* Конфигурация моделей:
			 * - установка ограничений на атрибуты
			 * - формирование связей между таблицами
			 * - настройка каскадных действий
			 */
			modelBuilder.ApplyConfiguration(new AccessLevelConfiguration());
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new StudentGroupConfiguration());
			modelBuilder.ApplyConfiguration(new GroupConfiguration());
			modelBuilder.ApplyConfiguration(new PositionConfiguration());
			modelBuilder.ApplyConfiguration(new TeacherConfiguration());
			#endregion

			#region Initialization database
			//инициализация бд данными

			modelBuilder.Entity<AccessLevel>().HasData(new Initialization_AccessLevel().Initialization);
			modelBuilder.Entity<User>().HasData(new Initialization_User().Initialization);
			modelBuilder.Entity<Group>().HasData(new Initialization_Group().Initialization);
			modelBuilder.Entity<StudentGroup>().HasData(new Initialization_StudentGroup().Initialization);
			modelBuilder.Entity<Position>().HasData(new Initialization_Position().Initialization);
			modelBuilder.Entity<Teacher>().HasData(new Initialization_Teacher().Initialization);

			#endregion
		}
	}

}
