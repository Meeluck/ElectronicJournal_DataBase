using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
	{
		public void Configure(EntityTypeBuilder<Lesson> builder)
		{
			builder.HasKey(l => l.LessonId);

			builder.HasMany(l => l.GroupLessons)
				.WithOne(gl => gl.Lesson)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(l => l.TeacherLessons)
				.WithOne(tl => tl.Lesson)
				.OnDelete(DeleteBehavior.Cascade);
			builder.HasMany(l => l.AcademicPerformances)
				.WithOne(ap => ap.Lesson)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
