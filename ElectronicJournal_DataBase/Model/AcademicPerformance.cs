using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	//Успеваемость
	public class AcademicPerformance
	{
		public int AcademicPerformanceId { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int LessonId { get; set; }
		public Lesson Lesson { get; set; }
		public string Mark { get; set; }
		
	}
}
