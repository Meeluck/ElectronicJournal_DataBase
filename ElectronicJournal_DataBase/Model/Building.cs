using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Building
	{
		public int BuildingId { get; set; }
		public string BuildingName { get; set; }
		public ICollection<Classroom> Classrooms { get; set; }
	}
}
