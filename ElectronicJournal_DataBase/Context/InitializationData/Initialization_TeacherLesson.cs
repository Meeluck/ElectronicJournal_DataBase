using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_TeacherLesson
	{
		private List<TeacherLesson> _teacherLessons = new List<TeacherLesson>();

		public Initialization_TeacherLesson()
		{
			//OC
			TeacherLesson tl1 = new TeacherLesson
			{
				TeacherLessonId = 1,
				TeacherId = 3,
				LessonId = 1
			};
			TeacherLesson tl2 = new TeacherLesson
			{
				TeacherLessonId = 2,
				TeacherId = 3,
				LessonId = 2
			};
			//WEB
			TeacherLesson tl3 = new TeacherLesson
			{
				TeacherLessonId = 3,
				TeacherId = 1,
				LessonId = 3
			};
			TeacherLesson tl4 = new TeacherLesson
			{
				TeacherLessonId = 4,
				TeacherId = 1,
				LessonId = 4
			};
			TeacherLesson tl5 = new TeacherLesson
			{
				TeacherLessonId = 5,
				TeacherId = 1,
				LessonId = 5
			};
			TeacherLesson tl6 = new TeacherLesson
			{
				TeacherLessonId = 6,
				TeacherId = 1,
				LessonId = 6
			};
			TeacherLesson tl7 = new TeacherLesson
			{
				TeacherLessonId = 7,
				TeacherId = 1,
				LessonId = 7
			};
			TeacherLesson tl8 = new TeacherLesson
			{
				TeacherLessonId = 8,
				TeacherId = 3,
				LessonId = 7
			};
			TeacherLesson tl9 = new TeacherLesson
			{
				TeacherLessonId = 9,
				TeacherId = 1,
				LessonId = 8
			};
			TeacherLesson tl10 = new TeacherLesson
			{
				TeacherLessonId = 10,
				TeacherId = 3,
				LessonId = 8
			};
			_teacherLessons.Add(tl1);
			_teacherLessons.Add(tl2);
			_teacherLessons.Add(tl3);
			_teacherLessons.Add(tl4);
			_teacherLessons.Add(tl5);
			_teacherLessons.Add(tl6);
			_teacherLessons.Add(tl7);
			_teacherLessons.Add(tl8);
			_teacherLessons.Add(tl9);
			_teacherLessons.Add(tl10);

		}

		public List<TeacherLesson> Initialization
		{
			get { return _teacherLessons; }
		}
	}
}
