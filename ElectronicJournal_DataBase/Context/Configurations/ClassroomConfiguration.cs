using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
	{
		public void Configure(EntityTypeBuilder<Classroom> builder)
		{
			builder.HasKey(cl => cl.ClassroomId);

			builder.HasMany(cl => cl.Lessons)
				.WithOne(ls => ls.Classroom)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
