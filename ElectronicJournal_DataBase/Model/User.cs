using System.Collections.Generic;
namespace ElectronicJournal_DataBase.Model
{
	public class User
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Login { get; set; }
		public string PasswordHash { get; set; }
		public string PasswordSalt { get; set; }

		public int? AccessLevelId { get; set; } //внешний ключ 
		public AccessLevel AccessLevel { get; set; } //навигациооне свойство для формирования связи 1:М
		public string Phone { get; set; }
		public string Email { get; set; }

		public StudentGroup StudentGroup { get; set; }
		public Teacher Teacher { get; set; }

		public ICollection<AcademicPerformance> AcademicPerformances { get; set; }
	}
}
