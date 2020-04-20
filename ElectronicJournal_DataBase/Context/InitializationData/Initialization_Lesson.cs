using System;
using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_Lesson 
	{
		private List<Lesson> _lessons = new List<Lesson>();

		public Initialization_Lesson()
		{
			//ОС
			Lesson l1 = new Lesson
			{
				LessonId = 1,
				Date = new DateTime(2020, 4, 25),
				TimeScheduleId = 1,
				SubjectId = 4,
				LessonTypeId = 1
			};
			Lesson l2 = new Lesson
			{
				LessonId = 2,
				Date = new DateTime(2020, 4, 25),
				TimeScheduleId = 2,
				SubjectId = 4,
				LessonTypeId = 1
			};
			//WEB
			Lesson l3 = new Lesson
			{
				LessonId = 3,
				Date = new DateTime(2020, 4, 28),
				TimeScheduleId = 3,
				SubjectId = 1,
				LessonTypeId = 1
			};
			Lesson l4 = new Lesson
			{
				LessonId = 4,
				Date = new DateTime(2020, 4, 28),
				TimeScheduleId = 4,
				SubjectId = 1,
				LessonTypeId = 3
			};
			Lesson l5 = new Lesson
			{
				LessonId = 5,
				Date = new DateTime(2020, 4, 28),
				TimeScheduleId = 5,
				SubjectId = 1,
				LessonTypeId = 3
			};
			//Пр-ие в ИС
			Lesson l6 = new Lesson
			{
				LessonId = 6,
				Date = new DateTime(2020, 4, 30),
				TimeScheduleId = 2,
				SubjectId = 2,
				LessonTypeId = 1
			};
			Lesson l7 = new Lesson
			{
				LessonId = 7,
				Date = new DateTime(2020, 4, 30),
				TimeScheduleId = 3,
				SubjectId = 2,
				LessonTypeId = 2
			};
			Lesson l8 = new Lesson
			{
				LessonId = 8,
				Date = new DateTime(2020, 4, 30),
				TimeScheduleId = 4,
				SubjectId = 2,
				LessonTypeId = 2
			};

			_lessons.Add(l1);
			_lessons.Add(l2);
			_lessons.Add(l3);
			_lessons.Add(l4);
			_lessons.Add(l5);
			_lessons.Add(l6);
			_lessons.Add(l7);
			_lessons.Add(l8);

		}

		public List<Lesson> Initialization
		{
			get { return _lessons; }
		}
	}
}
