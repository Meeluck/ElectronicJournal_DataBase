using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class TeacherLessonConfiguration : IEntityTypeConfiguration<TeacherLesson>
	{
		public void Configure(EntityTypeBuilder<TeacherLesson> builder)
		{
			builder.HasKey(tl => tl.TeacherLessonId);

		}
	}
}
