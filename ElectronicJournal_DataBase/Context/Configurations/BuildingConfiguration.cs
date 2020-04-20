using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class BuildingConfiguration : IEntityTypeConfiguration<Building>
	{
		public void Configure(EntityTypeBuilder<Building> builder)
		{
			builder.HasKey(b => b.BuildingId);
			builder.HasAlternateKey(b => b.BuildingName);

			builder.HasMany(b => b.Classrooms)
				.WithOne(cl => cl.Building)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
