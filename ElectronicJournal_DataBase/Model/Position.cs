using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicJournal_DataBase.Model
{
	public class Position
	{
		public int PositionId { get; set; }
		public string PositionName { get; set; }

		public ICollection<Teacher> Teachers { get; set; }
	}
}
