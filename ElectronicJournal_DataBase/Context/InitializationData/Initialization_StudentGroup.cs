using System;
using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_StudentGroup
	{
		private List<StudentGroup> _studentGroups = new List<StudentGroup>();
		public Initialization_StudentGroup()
		{
			StudentGroup sg1 = new StudentGroup
			{
				StudentGroupId = 1,
				UserId = 6,
				GroupId = 1
			};
			StudentGroup sg2 = new StudentGroup
			{
				StudentGroupId = 2,
				UserId = 7,
				GroupId = 1
			};
			StudentGroup sg3 = new StudentGroup
			{
				StudentGroupId = 3,
				UserId = 8,
				GroupId = 1
			};
			StudentGroup sg4 = new StudentGroup
			{
				StudentGroupId = 4,
				UserId = 13,
				GroupId = 2
			};
			StudentGroup sg5 = new StudentGroup
			{
				StudentGroupId = 5,
				UserId = 14,
				GroupId = 2
			};
			_studentGroups.Add(sg1);
			_studentGroups.Add(sg2);
			_studentGroups.Add(sg3);
			_studentGroups.Add(sg4);
			_studentGroups.Add(sg5);
		}
		public List<StudentGroup> Initialization
		{
			get { return _studentGroups; }
		}
	}
}
