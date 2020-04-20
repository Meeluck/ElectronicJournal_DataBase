using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Classroom
	{
		public int ClassroomId { get; set; }
		public string ClassroomName { get; set; }
		public int? BuildingId { get; set; }
		public Building Building { get; set; }

		public ICollection<Lesson> Lessons { get; set; }
	}
}
