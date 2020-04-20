using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_Teacher
	{
		private List<Teacher> _teachers = new List<Teacher>();

		public Initialization_Teacher()
		{
			Teacher t1 = new Teacher()
			{
				TeacherId = 1,
				UserId = 9,
				PositionId = 3
			};
			Teacher t2 = new Teacher()
			{
				TeacherId = 2,
				UserId = 10,
				PositionId = 4
			};
			Teacher t3 = new Teacher()
			{
				TeacherId = 3,
				UserId = 15,
				PositionId = 4
			};
			_teachers.Add(t1);
			_teachers.Add(t2);
			_teachers.Add(t3);
		}
		public List<Teacher> Initialization
		{
			get { return _teachers; }
		}
	}
}
