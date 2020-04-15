using System;
using System.Collections.Generic;
using System.Text;
using ElectronicJournal_Library;
using ElectronicJournal_DataBase.Model;
using ElectronicJournal_DataBase.Context;
namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_User
	{
		private List<User> _initialization = new List<User>();
		public Initialization_User()
		{
			Password pasStudent = new Password("1111");
			User studentUser = new User
			{
				UserId = 1,
				FirstName = "Student",
				LastName = "Studentovich",
				Login = "Student_1",
				PasswordSalt = pasStudent.PasswordSalt,
				PasswordHash = pasStudent.PasswordHash,
				AccessLevelId = 1,
				Phone = new string('1', 11),
				Email = "student@mail.ru"
			};
			Password pasStarosta = new Password("2222");
			User starostaUser = new User
			{
				UserId = 2,
				FirstName = "Starosta",
				LastName = "Starostovich",
				Login = "Starosta_1",
				PasswordSalt = pasStarosta.PasswordSalt,
				PasswordHash = pasStarosta.PasswordHash,
				AccessLevelId = 2,
				Phone = new string('2', 11),
				Email = "starosta@mail.ru"
			};
			Password pasPrepod = new Password("3333");
			User teacherUser = new User
			{
				UserId = 3,
				FirstName = "Prepod",
				LastName = "Prepodovich",
				Login = "Prepod_1",
				PasswordSalt = pasPrepod.PasswordSalt,
				PasswordHash = pasPrepod.PasswordHash,
				AccessLevelId = 3,
				Phone = new string('3', 11),
				Email = "prepod@mail.ru"
			};
			Password pasDekanat = new Password("4444");
			User dekanatUser = new User
			{
				UserId = 4,
				FirstName = "Dekanat",
				LastName = "Dekanat",
				Login = "Dekanat_1",
				PasswordSalt = pasDekanat.PasswordSalt,
				PasswordHash = pasDekanat.PasswordHash,
				AccessLevelId = 4,
				Phone = new string('4', 11),
				Email = "dekanat@mail.ru"
			};

			Password pasAdmin = new Password("5555");
			User adminUser = new User
			{
				UserId = 5,
				FirstName = "Admin",
				LastName = "Admin",
				Login = "Admin_1",
				PasswordSalt = pasAdmin.PasswordSalt,
				PasswordHash = pasAdmin.PasswordHash,
				AccessLevelId = 5,
				Phone = new string('5', 11),
				Email = "admin@mail.ru"
			};

			_initialization.Add(studentUser);
			_initialization.Add(starostaUser);
			_initialization.Add(teacherUser);
			_initialization.Add(dekanatUser);
			_initialization.Add(adminUser);
		}

		public List<User> Initialization
		{
			get { return _initialization; }
		}
	}
}
