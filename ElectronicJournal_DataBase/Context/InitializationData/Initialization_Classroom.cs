using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_Classroom
	{
		private List<Classroom> _classrooms = new List<Classroom>();

		public Initialization_Classroom()
		{
			Classroom cl1 = new Classroom()
			{
				ClassroomId = 1,
				ClassroomName = "403B",
				BuildingId = 1
			};
			Classroom cl2 = new Classroom()
			{
				ClassroomId = 2,
				ClassroomName = "404B",
				BuildingId = 1
			};
			Classroom cl3 = new Classroom()
			{
				ClassroomId = 3,
				ClassroomName = "423B",
				BuildingId = 1
			};
			Classroom cl4 = new Classroom()
			{
				ClassroomId = 4,
				ClassroomName = "608Б",
				BuildingId = 1
			};
			Classroom cl5 = new Classroom()
			{
				ClassroomId = 5,
				ClassroomName = "606Б",
				BuildingId = 1
			};
			Classroom cl6 = new Classroom()
			{
				ClassroomId = 6,
				ClassroomName = "722Б",
				BuildingId = 1
			};
			_classrooms.Add(cl1);
			_classrooms.Add(cl2);
			_classrooms.Add(cl3);
			_classrooms.Add(cl4);
			_classrooms.Add(cl5);
			_classrooms.Add(cl6);

		}

		public List<Classroom> Initialization
		{
			get { return _classrooms; }
		}
	}
}
