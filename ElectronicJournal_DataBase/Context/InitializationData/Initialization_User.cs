using System.Collections.Generic;
using ElectronicJournal_Library;
using ElectronicJournal_DataBase.Model;
namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_User
	{
		private List<User> _initialization = new List<User>();
		public Initialization_User()
		{
			#region Test Users
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
			#endregion
			
			_initialization.Add(studentUser);
			_initialization.Add(starostaUser);
			_initialization.Add(teacherUser);
			_initialization.Add(dekanatUser);
			_initialization.Add(adminUser);

			_initialization.AddRange(Group335());

			_initialization.AddRange(Teachers319kaf());

			_initialization.AddRange(Dekanat3Fac());

			_initialization.AddRange(Admins());

			_initialization.AddRange(Group333());
			_initialization.AddRange(Teachers316kaf());
		}

		public List<User> Initialization
		{
			get { return _initialization; }
		}

		#region Initialization methods
		private List<User> Group335()
		{
			Password ps_Anshukov_Mikhail= new Password("Anshukov");
			Password ps_Kornilov_Artem = new Password("Kornilov");
			Password ps_Milakov_Alex = new Password("Milakov");
			
			User Anshukov_Mikhail = new User
			{
				UserId = 6,
				FirstName = "Михаил",
				LastName = "Аншуков",
				Login = "Anshukov_Mikhail",
				PasswordSalt = ps_Anshukov_Mikhail.PasswordSalt,
				PasswordHash = ps_Anshukov_Mikhail.PasswordHash,
				AccessLevelId = 1
			};
			User Kornilov_Artem = new User
			{
				UserId = 7,
				FirstName = "Артем",
				LastName = "Корнилов",
				Login = "Kornilov_Artem",
				PasswordSalt = ps_Kornilov_Artem.PasswordSalt,
				PasswordHash = ps_Kornilov_Artem.PasswordHash,
				AccessLevelId = 1
			};
			//Статорста
			User Milakov_Alex = new User
			{
				UserId = 8,
				FirstName = "Александр",
				MiddleName = "Владимирович",
				LastName = "Милаков",
				Login = "Milakov_Alex",
				PasswordSalt = ps_Milakov_Alex.PasswordSalt,
				PasswordHash = ps_Milakov_Alex.PasswordHash,
				AccessLevelId = 2
			};

			List<User> _group335 = new List<User>();
			_group335.Add(Anshukov_Mikhail);
			_group335.Add(Kornilov_Artem);
			_group335.Add(Milakov_Alex);

			return _group335;
		}
		
		private List<User> Teachers319kaf()
		{
			List<User> teachers = new List<User>();
			Password ps_Konovalov = new Password("Konovalov");
			Password ps_Balakirev = new Password("Balakirev");
			User Konovalov_KA = new User
			{
				UserId = 9,
				FirstName = "Кирилл",
				MiddleName = "Андреевич",
				LastName = "Коновалов",
				Login = "Konovalov_K_A",
				PasswordSalt = ps_Konovalov.PasswordSalt,
				PasswordHash = ps_Konovalov.PasswordHash,
				AccessLevelId = 3
			};
			User Balakirev_NE = new User
			{
				UserId = 10,
				FirstName = "Николай",
				MiddleName = "Евгеньевич",
				LastName = "Балакирев",
				Login = "Balakirev_N_E",
				PasswordSalt = ps_Balakirev.PasswordSalt,
				PasswordHash = ps_Balakirev.PasswordHash,
				AccessLevelId = 3
			};

			teachers.Add(Konovalov_KA);
			teachers.Add(Balakirev_NE);

			return teachers;
		}

		private List<User> Dekanat3Fac()
		{
			List<User> dekanat = new List<User>();
			Password ps_ZamDekan = new Password("ZamDekan");
			User Zam_Dekan = new User
			{
				UserId = 11,
				FirstName = "Декана",
				LastName = "Заместитель",
				Login = "Zam_Dekan",
				PasswordHash = ps_ZamDekan.PasswordHash,
				PasswordSalt = ps_ZamDekan.PasswordSalt,
				AccessLevelId = 4
			};
			dekanat.Add(Zam_Dekan);
			return dekanat;
		}

		private List<User> Admins()
		{
			List<User> admins = new List<User>();
			Password ps_MeeLuckAdmin = new Password("Meeluck");
			User MeeluckAdmin = new User
			{
				UserId = 12,
				FirstName = "Alexander",
				LastName = "Milakov",
				Login = "Meeluck",
				PasswordSalt = ps_MeeLuckAdmin.PasswordSalt,
				PasswordHash = ps_MeeLuckAdmin.PasswordHash,
				AccessLevelId = 5
			};
			admins.Add(MeeluckAdmin);

			return admins;
		}

		private List<User> Group333()
		{
			List<User> group333 = new List<User>();

			Password ps_Mayer = new Password("Mayer");
			Password ps_Volkov = new Password("Volkov");

			User Nikita_Mayer = new User
			{
				UserId = 13,
				FirstName = "Никита",
				LastName = "Майер",
				Login = "Mayer",
				PasswordHash = ps_Mayer.PasswordHash,
				PasswordSalt = ps_Mayer.PasswordSalt,
				AccessLevelId = 2
			};
			User Volkov_Ivan = new User
			{
				UserId = 14,
				FirstName = "Иван",
				LastName = "Волков",
				Login = "Volkov",
				PasswordHash = ps_Volkov.PasswordHash,
				PasswordSalt = ps_Volkov.PasswordSalt,
				AccessLevelId = 1
			};
			group333.Add(Nikita_Mayer);
			group333.Add(Volkov_Ivan);

			return group333;
		}

		private List<User > Teachers316kaf()
		{
			List<User> teachers = new List<User>();
			Password ps_Semenov = new Password("Semenov");
			//Semenov Grigory Evgenievich
			User Semenov_Grigory = new User
			{
				UserId = 15,
				FirstName = "Григорий",
				MiddleName = "Евгеньевич",
				LastName = "Семёнов",
				Login = "Semenov_Grigory",
				PasswordHash = ps_Semenov.PasswordHash,
				PasswordSalt = ps_Semenov.PasswordSalt,
				AccessLevelId = 3,
			};
			teachers.Add(Semenov_Grigory);
			return teachers;
		}

		#endregion

	}
}
