using System;
using System.Collections.Generic;
using System.Text;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Model
{
	public class AccessLevel
	{
		public int AccessLevelId { get; set; }
		public string AccessLevelName { get; set; }
		
		public ICollection<User> Users { get; set; } // навигационное св-во для формирования связи M:1
	}
}
