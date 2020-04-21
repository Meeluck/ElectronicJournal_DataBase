using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class AcademicPerformanceConfiguration : IEntityTypeConfiguration<AcademicPerformance>
	{
		public void Configure(EntityTypeBuilder<AcademicPerformance> builder)
		{
			builder.HasKey(ap => ap.AcademicPerformanceId);

		}
	}
}
