using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class StudentGroup
	{
		public int StudentGroupId { get; set; }

		public int UserId { get; set; }
		public User User { get; set; }

		public int? GroupId { get; set; }
		public Group Group { get; set; }


	}
}
