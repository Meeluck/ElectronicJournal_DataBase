using System;
using System.Collections.Generic;
using System.Text;
namespace ElectronicJournal_DataBase.Model
{
	public class TeacherLesson 
	{
		public int TeacherLessonId { get; set; }
		public int TeacherId { get; set; }
		public Teacher Teacher { get; set; }
		public int LessonId { get; set; }
		public Lesson Lesson { get; set; }
	}
}
