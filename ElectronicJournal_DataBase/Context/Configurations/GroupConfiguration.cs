using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class GroupConfiguration : IEntityTypeConfiguration<Group>
	{
		public void Configure(EntityTypeBuilder<Group> builder)
		{
			//первичный ключ
			builder.HasKey(gr => gr.GroupId);

			//название группы должно быть уникально и обязательно должно быть
			builder.HasAlternateKey(gr => gr.GroupName);
			//год формирования группы
			builder.Property(gr => gr.YearFormationGroup).IsRequired();

			builder.Property(gr => gr.UserId).HasColumnName("StarostaId");
			//связь М:1 с таблицей StudentGroup
			builder.HasMany(gr => gr.StudentGroups)
				.WithOne(sg => sg.Group)
				.HasForeignKey(gr => gr.GroupId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
