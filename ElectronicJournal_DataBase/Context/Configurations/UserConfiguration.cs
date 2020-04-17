using ElectronicJournal_DataBase.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ElectronicJournal_DataBase.Context.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			//Первичный ключ
			builder.HasKey(u => u.UserId);

			//ограничения на Имя
			builder.Property(u => u.FirstName)
				.IsRequired()
				.HasMaxLength(50);

			//ограничения на Отчетсво
			builder.Property(u => u.MiddleName)
				.HasMaxLength(50);

			//ограничения на фамилию
			builder.Property(u => u.LastName)
				.IsRequired()
				.HasMaxLength(50);

			//ограничения на Логин
			builder.Property(u => u.Login)
				.IsRequired()
				.HasMaxLength(30);
			builder.HasAlternateKey(u => u.Login);

			//ограничения на пароль
			builder.Property(u => u.PasswordHash)
				.IsRequired();
			builder.Property(u => u.PasswordSalt)
				.IsRequired();

			//ограничения на Почту
			builder.Property(u => u.Email)
				.HasMaxLength(100);
			//builder.HasAlternateKey(u => u.Email);

			//ограничения на телефон
			builder.Property(u => u.Phone)
				.HasMaxLength(12);
			//builder.HasAlternateKey(u => u.Phone);

			//связь 1:1 с таблицей studentGroup
			builder.HasOne(u => u.StudentGroup)
				.WithOne(sg => sg.User)
				.OnDelete(DeleteBehavior.Cascade);
			//связь 1:1 с таблицей Teacher
			builder.HasOne(u => u.Teacher)
				.WithOne(t => t.User)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
