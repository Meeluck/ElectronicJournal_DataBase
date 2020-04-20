using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class LessonType
	{
		public int LessonTypeId { get; set; }
		public string LessonTypeName { get; set; }
		public ICollection<Lesson> Lessons { get; set; }
	}
}
