using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
	{
		public void Configure(EntityTypeBuilder<Teacher> builder)
		{
			//первичный ключи
			builder.HasKey(tc => tc.TeacherId);
			//преподаватели должны быть уникальными
			builder.HasAlternateKey(tc => tc.UserId);

		}
	}
}
