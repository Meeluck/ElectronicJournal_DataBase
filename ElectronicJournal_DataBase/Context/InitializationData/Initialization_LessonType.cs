using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_LessonType
	{
		private List<LessonType> _lessonTypes = new List<LessonType>();

		public Initialization_LessonType()
		{
			LessonType lt1 = new LessonType()
			{
				LessonTypeId = 1,
				LessonTypeName = "Лекция"
			};
			LessonType lt2 = new LessonType()
			{
				LessonTypeId = 2,
				LessonTypeName = "Практическое занятие"
			};

			LessonType lt3 = new LessonType()
			{
				LessonTypeId = 3,
				LessonTypeName = "Лабораторная работа"
			};
			LessonType lt4 = new LessonType()
			{
				LessonTypeId = 4,
				LessonTypeName = "Экзамен"
			};
			LessonType lt5 = new LessonType()
			{
				LessonTypeId = 5,
				LessonTypeName = "Зачет"
			};
			_lessonTypes.Add(lt1);
			_lessonTypes.Add(lt2);
			_lessonTypes.Add(lt3);
			_lessonTypes.Add(lt4);
			_lessonTypes.Add(lt5);
		}
		public List<LessonType> Initialization
		{
			get { return _lessonTypes; }
		}
	}
}
