using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Subject
	{
		public int SubjectId { get; set; }
		public string SubjectName { get; set; }

		public ICollection<Lesson> Lessons { get; set; }
	}
}
