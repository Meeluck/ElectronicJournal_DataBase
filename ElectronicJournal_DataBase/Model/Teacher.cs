using System.Collections.Generic;

namespace ElectronicJournal_DataBase.Model
{
	public class Teacher
	{
		public int TeacherId { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int? PositionId { get; set; }
		public Position Position { get; set; }
		
		public ICollection<TeacherLesson> TeacherLessons { get; set; }
	}
}
