using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
	{
		public void Configure(EntityTypeBuilder<Subject> builder)
		{
			builder.HasKey(s => s.SubjectId);
			builder.HasAlternateKey(s => s.SubjectName);

			builder.HasMany(s => s.Lessons)
				.WithOne(l => l.Subject);

		}
	}
}
