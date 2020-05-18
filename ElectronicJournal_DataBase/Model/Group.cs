using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Group
	{
		public int GroupId { get; set; }

		public string GroupName { get; set; }

		public DateTime YearFormationGroup { get; set; }

		public ICollection<StudentGroup> StudentGroups { get; set; }
		public ICollection<GroupLesson> GroupLessons { get; set; }

	}
}
