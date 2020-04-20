using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class GroupLesson
	{
		public int GroupLessonId { get; set; }
		public int LessonId { get; set; }
		public Lesson Lesson { get; set; }
		public int GroupId { get; set; }
		public Group Group { get; set; }
	}
}
