using System;
using System.Collections.Generic;
using System.Text;
using ElectronicJournal_DataBase.Model;
using ElectronicJournal_DataBase.Context;

namespace ElectronicJournal_DataBase.Context.InitializationData
{

	public class Initialization_AccessLevel
	{
		List<AccessLevel> _initialization;
		/* Уровни доступа
			 * 1-студент
			 * 2-староста
			 * 3-препоадватель
			 * 4-деканат
			 * 5-админ */
		public Initialization_AccessLevel()
		{
			_initialization = new List<AccessLevel>
			{
				new AccessLevel { AccessLevelId=1, AccessLevelName = "Студент" },
				new AccessLevel { AccessLevelId = 2, AccessLevelName = "Староста" },
				new AccessLevel { AccessLevelId = 3, AccessLevelName = "Преподаватель" },
				new AccessLevel { AccessLevelId = 4, AccessLevelName = "Деканат" },
				new AccessLevel { AccessLevelId = 5, AccessLevelName = "Админ" }
			};
		}
		public List<AccessLevel> Initialization
		{
			get
			{
				return _initialization;
			}
		}
	}

}
