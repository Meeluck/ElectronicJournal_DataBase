using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_Subject
	{
		private List<Subject> _subjects = new List<Subject>();
		public Initialization_Subject()
		{
			Subject sb1 = new Subject()
			{
				SubjectId = 1,
				SubjectName = "Web-программирование"
			};
			Subject sb2 = new Subject()
			{
				SubjectId = 2,
				SubjectName = "Программирование в информационных системах"
			};
			Subject sb3 = new Subject()
			{
				SubjectId = 3,
				SubjectName = "Машинно-ориентированное программирование"
			};
			Subject sb4 = new Subject
			{
				SubjectId = 4,
				SubjectName = "Операционные системы"
			};

			_subjects.Add(sb1);
			_subjects.Add(sb2);
			_subjects.Add(sb3);
			_subjects.Add(sb4);

		}
		public List<Subject> Initialization
		{
			get { return _subjects; }
		}
	}
}
