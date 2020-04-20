using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;
namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_TimeSchedule
	{
		private List<TimeSchedule> _timeSchedules = new List<TimeSchedule>();
		public Initialization_TimeSchedule()
		{
			TimeSchedule ts1 = new TimeSchedule()
			{
				TimeScheduleId = 1,
				TimeInterval = "09:00 – 10:30"
			};
			TimeSchedule ts2 = new TimeSchedule()
			{
				TimeScheduleId = 2,
				TimeInterval = "10:45 – 12:15"
			};
			TimeSchedule ts3 = new TimeSchedule()
			{
				TimeScheduleId = 3,
				TimeInterval = "13:00 – 14:30"
			};
			TimeSchedule ts4 = new TimeSchedule()
			{
				TimeScheduleId = 4,
				TimeInterval = "14:45 – 16:15"
			};
			TimeSchedule ts5 = new TimeSchedule()
			{
				TimeScheduleId = 5,
				TimeInterval = "16:30 – 18:00"
			};
			TimeSchedule ts6 = new TimeSchedule()
			{
				TimeScheduleId = 6,
				TimeInterval = "18:15 – 19:45"
			};
			TimeSchedule ts7 = new TimeSchedule()
			{
				TimeScheduleId = 7,
				TimeInterval = "20:00 – 21:30"
			};
			_timeSchedules.Add(ts1);
			_timeSchedules.Add(ts2);
			_timeSchedules.Add(ts3);
			_timeSchedules.Add(ts4);
			_timeSchedules.Add(ts5);
			_timeSchedules.Add(ts6);
			_timeSchedules.Add(ts7);

		}
		public List<TimeSchedule> Initialization
		{
			get { return _timeSchedules; }
		}
	}
}
