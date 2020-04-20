using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;
namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_GroupLesson
	{
		private List<GroupLesson> _groupLessons = new List<GroupLesson>();

		public Initialization_GroupLesson()
		{
			//OC
			GroupLesson gl1 = new GroupLesson
			{
				GroupLessonId = 1,
				GroupId = 1,
				LessonId = 1
			};
			GroupLesson gl2 = new GroupLesson
			{
				GroupLessonId = 2,
				GroupId = 2,
				LessonId = 1
			};
			GroupLesson gl3 = new GroupLesson
			{
				GroupLessonId = 3,
				GroupId = 1,
				LessonId = 2
			};
			GroupLesson gl4 = new GroupLesson
			{
				GroupLessonId = 4,
				GroupId = 2,
				LessonId = 2
			};
			//web
			GroupLesson gl5 = new GroupLesson
			{
				GroupLessonId = 5,
				GroupId = 1,
				LessonId = 3
			};
			GroupLesson gl6 = new GroupLesson
			{
				GroupLessonId = 6,
				GroupId = 1,
				LessonId = 4
			};
			GroupLesson gl7 = new GroupLesson
			{
				GroupLessonId = 7,
				GroupId = 1,
				LessonId = 5
			};
			//ИС
			GroupLesson gl8 = new GroupLesson
			{
				GroupLessonId = 8,
				GroupId = 1,
				LessonId = 6
			};
			GroupLesson gl9 = new GroupLesson
			{
				GroupLessonId = 9,
				GroupId = 1,
				LessonId = 7
			};
			GroupLesson gl10 = new GroupLesson
			{
				GroupLessonId = 10,
				GroupId = 1,
				LessonId = 8
			};

			_groupLessons.Add(gl1);
			_groupLessons.Add(gl2);
			_groupLessons.Add(gl3);
			_groupLessons.Add(gl4);
			_groupLessons.Add(gl5);
			_groupLessons.Add(gl6);
			_groupLessons.Add(gl7);
			_groupLessons.Add(gl8);
			_groupLessons.Add(gl9);
			_groupLessons.Add(gl10);

		}

		public List<GroupLesson> Initialization
		{
			get { return _groupLessons; }
		}
	}
}
