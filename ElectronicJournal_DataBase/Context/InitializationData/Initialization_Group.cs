using System;
using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_Group
	{
		private List<Group> _groups = new List<Group>();
		
		public Initialization_Group()
		{
			Group gr335 = new Group
			{
				GroupId = 1,
				GroupName = "М3О-335Б-17",
				YearFormationGroup = new DateTime(2017, 7, 30)
			};
			_groups.Add(gr335);
		}
		public List<Group> Initialization
		{
			get { return _groups; }
		}

	}
}
