using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Teacher
	{
		public int TeacherId { get; set; }
		public int UserId { get; set; }
		public User User { get; set; }
		public int? PositionId { get; set; }
		public Position Position { get; set; }
	}
}
