using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class GroupLessonConfiguration : IEntityTypeConfiguration<GroupLesson>
	{
		public void Configure(EntityTypeBuilder<GroupLesson> builder)
		{
			builder.HasKey(gl => gl.GroupLessonId);
		}
	}
}
