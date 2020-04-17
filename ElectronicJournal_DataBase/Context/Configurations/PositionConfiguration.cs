using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class PositionConfiguration : IEntityTypeConfiguration<Position>
	{
		public void Configure(EntityTypeBuilder<Position> builder)
		{
			//первичный ключи
			builder.HasKey(ps => ps.PositionId);
			//наименование должности должно быть уникальным
			builder.HasAlternateKey(ps => ps.PositionName);
			/* связь М:1 с таблицей прподавателей. При удалении данных 
			 * из таблицы Position в таблице Teacher устанавливаем в 
			 * соответсвующее поле устанавливаем NULL*/
			builder.HasMany(ps => ps.Teachers)
				.WithOne(t => t.Position)
				.OnDelete(DeleteBehavior.SetNull);
		}
	}
}
