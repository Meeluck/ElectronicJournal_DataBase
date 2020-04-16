using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class StudentGroupConfiguration : IEntityTypeConfiguration<StudentGroup>
	{
		public void Configure(EntityTypeBuilder<StudentGroup> builder)
		{
			//задаем первичный ключ
			builder.HasKey(sg => sg.StudentGroupId);

			//студент может принадлежать только одной группе
			builder.HasAlternateKey(sg => sg.UserId);

			//builder.HasOne(sg => sg.Group)
			//	.WithMany(gr => gr.StudentGroups)
			//	.HasForeignKey(sg => sg.GroupId)
			//	.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
