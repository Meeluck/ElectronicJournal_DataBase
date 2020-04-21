using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Lesson
	{
		public int LessonId { get; set; }
		
		public DateTime Date { get; set; }
		public int? TimeScheduleId { get; set; }
		public TimeSchedule TimeSchedule { get; set; }
		public int SubjectId { get; set; }
		public Subject Subject { get; set; }
		public int? LessonTypeId { get; set; }
		public LessonType LessonType { get; set; }
		public int? ClassroomId { get; set; }
		public Classroom Classroom { get; set; }
		
		public string Notes { get; set; }

		public ICollection<GroupLesson> GroupLessons { get; set; }
		public ICollection<TeacherLesson> TeacherLessons { get; set; }
		public ICollection<AcademicPerformance> AcademicPerformances { get; set; }
	}
}
