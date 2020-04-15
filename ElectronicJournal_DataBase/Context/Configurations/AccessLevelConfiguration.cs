using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class AccessLevelConfiguration : IEntityTypeConfiguration<AccessLevel>
	{
		public void Configure(EntityTypeBuilder<AccessLevel> builder)
		{
			builder.HasKey(al => al.AccessLevelId);
			//связь М:1 с таблицей пользователей
			builder.HasMany(u => u.Users)
				.WithOne(al => al.AccessLevel)
				.HasForeignKey(al => al.AccessLevelId)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
