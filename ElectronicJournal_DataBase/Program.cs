using System;
using ElectronicJournal_DataBase.Context;
using ElectronicJournal_DataBase.Model;
using ElectronicJournal_Library;

namespace ElectronicJournal_DataBase
{
	class Program
	{
		static void Main(string[] args)
		{
			//AccessLevel alStud = new AccessLevel { /*AccessLevelId = 1,*/ AccessLevelName = "Студент" };
			//AccessLevel alStarosta = new AccessLevel {/* AccessLevelId = 2,*/ AccessLevelName = "Староста" };
			//AccessLevel alTeacher = new AccessLevel {/* AccessLevelId = 3,*/ AccessLevelName = "Преподаватель" };
			//AccessLevel alDekanat = new AccessLevel { /*AccessLevelId = 4,*/ AccessLevelName = "Деканат" };
			//AccessLevel alAdmin = new AccessLevel { /*AccessLevelId = 5,*/ AccessLevelName = "Админ" };


			using (ElectronicJournalContext db = new ElectronicJournalContext())
			{
				//AccessLevel alStud = new AccessLevel {AccessLevelId=1, AccessLevelName = "Студент" };
				//AccessLevel alStarosta = new AccessLevel { AccessLevelId = 2, AccessLevelName = "Староста" };
				//AccessLevel alTeacher = new AccessLevel { AccessLevelId = 3, AccessLevelName = "Преподаватель" };
				//AccessLevel alDekanat = new AccessLevel { AccessLevelId = 4, AccessLevelName = "Деканат" };
				//AccessLevel alAdmin = new AccessLevel { AccessLevelId = 5, AccessLevelName = "Админ" };
				//db.AccessLevels.Add(alStud);
				//db.AccessLevels.Add(alStarosta);
				//db.AccessLevels.Add(alTeacher);
				//db.AccessLevels.Add(alDekanat);
				//db.AccessLevels.Add(alAdmin);

				//Password pasStudent = new Password("1111");
				//User studentUser = new User
				//{
				//	UserId = 1,
				//	FirstName = "Student",
				//	LastName = "Studentovich",
				//	Login = "Student_1",
				//	PasswordSalt = pasStudent.PasswordSalt,
				//	PasswordHash = pasStudent.PasswordHash,
				//	AccessLevelId = 1,
				//	Phone = new string('1', 12),
				//	Email = "student@mail.ru"
				//};
				//Password pasStarosta = new Password("2222");
				//User starostaUser = new User
				//{
				//	UserId = 2,
				//	FirstName = "Starosta",
				//	LastName = "Starostovich",
				//	Login = "Starosta_1",
				//	PasswordSalt = pasStarosta.PasswordSalt,
				//	PasswordHash = pasStarosta.PasswordHash,
				//	AccessLevelId = 2,
				//	Phone = new string('2', 12),
				//	Email = "starosta@mail.ru"
				//};
				//Password pasPrepod = new Password("3333");
				//User teacherUser = new User
				//{
				//	UserId = 3,
				//	FirstName = "Prepod",
				//	LastName = "Prepodovich",
				//	Login = "Prepod_1",
				//	PasswordSalt = pasPrepod.PasswordSalt,
				//	PasswordHash = pasPrepod.PasswordHash,
				//	AccessLevelId = 2,
				//	Phone = new string('3', 12),
				//	Email = "prepod@mail.ru"
				//};
				//Password pasDekanat = new Password("4444");
				//User dekanatUser = new User
				//{
				//	UserId = 4,
				//	FirstName = "Dekanat",
				//	LastName = "Dekanat",
				//	Login = "Dekanat_1",
				//	PasswordSalt = pasDekanat.PasswordSalt,
				//	PasswordHash = pasDekanat.PasswordHash,
				//	AccessLevelId = 4,
				//	Phone = new string('4', 12),
				//	Email = "dekanat@mail.ru"
				//};

				//Password pasAdmin = new Password("5555");
				//User adminUser = new User
				//{
				//	UserId = 5,
				//	FirstName = "Admin",
				//	LastName = "Admin",
				//	Login = "Admin_1",
				//	PasswordSalt = pasAdmin.PasswordSalt,
				//	PasswordHash = pasAdmin.PasswordHash,
				//	AccessLevelId = 5,
				//	Phone = new string('5', 12),
				//	Email = "admin@mail.ru"
				//};

				//db.Users.Add(studentUser);
				//db.Users.Add(starostaUser);
				//db.Users.Add(teacherUser);
				//db.Users.Add(dekanatUser);
				//db.Users.Add(adminUser);
			}


			Console.WriteLine("Все сработало, вроде");
			Console.ReadKey();
		}
	}
}
