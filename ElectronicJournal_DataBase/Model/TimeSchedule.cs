using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class TimeSchedule
	{
		public int TimeScheduleId { get; set; }
		public string TimeInterval { get; set; }
		public ICollection<Lesson> Lessons { get; set; }

	}
}
