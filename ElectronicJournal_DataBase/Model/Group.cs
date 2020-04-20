using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Group
	{
		public int GroupId { get; set; }
		public string GroupName { get; set; }

		//public int NumberOfCourse { get; set; }
		//public int NubmerOfSemestr { get; set; }
		public DateTime YearFormationGroup { get; set; }
		//староста
		public int? UserId{ get; set; }
		public User User { get; set; }


		public ICollection<StudentGroup> StudentGroups { get; set; }
		public ICollection<GroupLesson> GroupLessons { get; set; }

	}
}
