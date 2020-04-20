using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class TimeScheduleConfiguration : IEntityTypeConfiguration<TimeSchedule>
	{
		public void Configure(EntityTypeBuilder<TimeSchedule> builder)
		{
			builder.HasKey(ts => ts.TimeScheduleId);
			builder.HasAlternateKey(ts => ts.TimeInterval);

			builder.HasMany(ts => ts.Lessons)
				.WithOne(l => l.TimeSchedule)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
