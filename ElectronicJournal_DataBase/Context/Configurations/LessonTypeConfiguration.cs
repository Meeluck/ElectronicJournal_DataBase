using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class LessonTypeConfiguration :IEntityTypeConfiguration<LessonType>
	{
		public void Configure(EntityTypeBuilder<LessonType> builder)
		{
			builder.HasKey(lt => lt.LessonTypeId);
			builder.HasAlternateKey(lt => lt.LessonTypeName);

			builder.HasMany(lt => lt.Lessons)
				.WithOne(l => l.LessonType)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
