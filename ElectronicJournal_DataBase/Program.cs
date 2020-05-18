using System;
using ElectronicJournal_DataBase.Context;
using ElectronicJournal_DataBase.Model;
using System.Linq;
using ElectronicJournal_Library;
using Microsoft.EntityFrameworkCore;
using ElectronicJournal_DataBase.TestsOfWork;

namespace ElectronicJournal_DataBase
{
	class Program
	{
		static void Main(string[] args)
		{
			#region firstTest
			//using (ElectronicJournalContext db = new ElectronicJournalContext())
			//{

			//	var al = db.AccessLevels;
			//	foreach (AccessLevel level in al)
			//	{
			//		Console.WriteLine($"{level.AccessLevelId}" + ": " + $"{level.AccessLevelName}");
			//	}

			//	Console.WriteLine(new string('-', 50));
			//	var test_us = db.Users.Select(us => new Person
			//	{
			//		Name = us.FirstName + " " + us.LastName,
			//		AccessLevel = us.AccessLevel.AccessLevelName
			//	});

			//	foreach (Person pr in test_us)
			//	{
			//		Console.WriteLine($"{pr.Name}" + ": " + $"{ pr.AccessLevel}");
			//	}
			//	Console.WriteLine(new string('-',50));
			//	var stud_group = from gr in db.Groups
			//					 join sg in db.StudentGroups on gr.GroupId equals sg.GroupId
			//					 join us in db.Users on sg.UserId equals us.UserId
			//					 join acl in db.AccessLevels on us.AccessLevelId equals acl.AccessLevelId
			//					 select new
			//					 {
			//						 Userid = us.UserId,
			//						 Name = us.LastName + " " + us.FirstName,
			//						 MName = !string.IsNullOrEmpty(us.MiddleName)? us.MiddleName : string.Empty,
			//						 gr.GroupName,
			//						 Al = acl.AccessLevelName
			//					 };


			//	foreach (var item in stud_group)
			//	{
			//		Console.WriteLine($" {item.Userid} {item.Name} {item.MName} {item.GroupName}  {item.Al}");
			//	}
			//	Console.WriteLine(new string('-',50));

			//	var use = from user in db.Users
			//			 where user.Login == "Meeluck"
			//			 select new User
			//			 {
			//				 UserId = user.UserId,
			//				 FirstName = user.FirstName,
			//				 MiddleName = !string.IsNullOrEmpty(user.MiddleName) ? user.MiddleName : string.Empty,
			//				 LastName = user.LastName,
			//				 Login = user.Login,
			//				 PasswordHash = user.PasswordHash,
			//				 PasswordSalt = user.PasswordSalt,
			//				 AccessLevelId = user.AccessLevelId,
			//				 Phone = !string.IsNullOrEmpty(user.Phone) ? user.Phone : string.Empty,
			//				 Email = !string.IsNullOrEmpty(user.Email) ? user.Email : string.Empty,
			//			 };
			//	foreach (var item in use)
			//	{
			//		Console.WriteLine(item.UserId);
			//		Console.WriteLine(item.FirstName);
			//		Console.WriteLine(item.MiddleName);
			//		Console.WriteLine(item.LastName);
			//		Console.WriteLine(item.Login);
			//		Console.WriteLine(item.PasswordHash);
			//		Console.WriteLine(item.PasswordSalt);
			//		Console.WriteLine(item.AccessLevelId);
			//		Console.WriteLine(item.Phone);
			//		Console.WriteLine(item.Email);
			//	}

			//}
			#endregion
			//Console.WriteLine("Все сработало, вроде");

			//ManagingUserAccounts test = new ManagingUserAccounts();
			//foreach(GeneralUserInformation item in test.GetUsersCollection)
			//{
			//	Console.WriteLine(item.UserId + " " + item.FullName + " " +item.AccessLevelName );
			//}

			using (ElectronicJournalContext db = new ElectronicJournalContext())
			{
				var test = from us in db.Users
						   join al in db.AccessLevels on us.AccessLevelId equals al.AccessLevelId
						   where us.UserId == 1
						   select new
						   {
							   UserId = us.UserId,
							   FirstName = us.FirstName,
							   MiddleName = !string.IsNullOrEmpty(us.MiddleName) ? us.MiddleName : string.Empty,
							   LastName = us.LastName,
							   Login = us.Login,
							   PasswordHash = us.PasswordHash,
							   PasswordSalt = us.PasswordSalt,
							   AccessLevelId = us.AccessLevelId,
							   AcessLevelName = al.AccessLevelName
						   };

				foreach (var item in test)
				{
					Console.WriteLine(item.UserId);
					Console.WriteLine(item.LastName);
					Console.WriteLine(item.FirstName);
					Console.WriteLine(item.MiddleName);
					Console.WriteLine(item.Login);
					Console.WriteLine(item.AccessLevelId);
					Console.WriteLine(item.AcessLevelName);
				}
				Console.WriteLine("test"+new string('-', 50));

				var student_test = from us in db.Users
								   join al in db.AccessLevels on us.AccessLevelId equals al.AccessLevelId
								   join stGr in db.StudentGroups on us.UserId equals stGr.UserId
								   into Datails
								   from d in Datails.DefaultIfEmpty()
								   where us.UserId == 1
								   select new
								   {
									   UserId = us.UserId,
									   FirstName = us.FirstName,
									   MiddleName = !string.IsNullOrEmpty(us.MiddleName) ? us.MiddleName : string.Empty,
									   LastName = us.LastName,
									   Login = us.Login,
									   PasswordHash = us.PasswordHash,
									   PasswordSalt = us.PasswordSalt,
									   AccessLevelId = us.AccessLevelId,
									   AcessLevelName = al.AccessLevelName,
									   Email = us.Email,
									   Phone = us.Phone,
									   GroupId = d.GroupId
								   };
				foreach (var item in student_test)
				{
					Console.WriteLine("id " + item.UserId);
					Console.WriteLine("last name " + item.LastName);
					Console.WriteLine("FirstName " + item.FirstName);
					Console.WriteLine("MiddleName " + item.MiddleName);
					Console.WriteLine("Login " + item.Login);
					Console.WriteLine("AccessLevelId " + item.AccessLevelId);
					Console.WriteLine("AcessLevelName " + item.AcessLevelName);
					Console.WriteLine("email " + item.Email);
					Console.WriteLine("Phone " + item.Phone);
					Console.WriteLine("GroupId " + item.GroupId);
					//Console.WriteLine("GroupName" + item.GroupName);
				}

				Console.WriteLine("need" + new string('-', 50));

				var student = from us in db.Users
							  join al in db.AccessLevels on us.AccessLevelId equals al.AccessLevelId
							  join stGr in db.StudentGroups on us.UserId equals stGr.UserId
							  into stGrDatails
							  from stGrDat in stGrDatails.DefaultIfEmpty()
							  join gr in db.Groups on stGrDat.GroupId equals gr.GroupId
							  into grDatails
							  from grDat in grDatails.DefaultIfEmpty()
							  where us.UserId == 1
							  select new
							  {
								  UserId = us.UserId,
								  FirstName = us.FirstName,
								  MiddleName = !string.IsNullOrEmpty(us.MiddleName) ? us.MiddleName : string.Empty,
								  LastName = us.LastName,
								  Login = us.Login,
								  PasswordHash = us.PasswordHash,
								  PasswordSalt = us.PasswordSalt,
								  AccessLevelId = us.AccessLevelId,
								  AcessLevelName = al.AccessLevelName,
								  Email = us.Email,
								  Phone = us.Phone,
								  GroupId = stGrDat.GroupId,
								  GroupName = !string.IsNullOrEmpty(grDat.GroupName) ? grDat.GroupName : string.Empty
							  };

				foreach (var item in student)
				{
					Console.WriteLine("id " + item.UserId);
					Console.WriteLine("last name " + item.LastName);
					Console.WriteLine("FirstName " + item.FirstName);
					Console.WriteLine("MiddleName " + item.MiddleName);
					Console.WriteLine("Login " + item.Login);
					Console.WriteLine("AccessLevelId " + item.AccessLevelId);
					Console.WriteLine("AcessLevelName " + item.AcessLevelName);
					Console.WriteLine("email " + item.Email);
					Console.WriteLine("Phone " + item.Phone);
					Console.WriteLine("GroupId " + item.GroupId);
					Console.WriteLine("GroupName" + item.GroupName);
				}
			}

				Console.ReadKey();
		}
	}
	public class Person
	{
		public string Name { get; set; }
		public string AccessLevel { get; set; }
	}
}
