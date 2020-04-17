using System;
using ElectronicJournal_DataBase.Context;
using ElectronicJournal_DataBase.Model;
using System.Linq;
using ElectronicJournal_Library;
using Microsoft.EntityFrameworkCore;
namespace ElectronicJournal_DataBase
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ElectronicJournalContext db = new ElectronicJournalContext())
			{

				var al = db.AccessLevels;
				foreach (AccessLevel level in al)
				{
					Console.WriteLine($"{level.AccessLevelId}" + ": " + $"{level.AccessLevelName}");
				}

				Console.WriteLine(new string('-', 50));
				var test_us = db.Users.Select(us => new Person
				{
					Name = us.FirstName + " " + us.LastName,
					AccessLevel = us.AccessLevel.AccessLevelName
				});

				foreach (Person pr in test_us)
				{
					Console.WriteLine($"{pr.Name}" + ": " + $"{ pr.AccessLevel}");
				}
				Console.WriteLine(new string('-',50));
				var stud_group = from gr in db.Groups
								 join sg in db.StudentGroups on gr.GroupId equals sg.GroupId
								 join us in db.Users on sg.UserId equals us.UserId
								 join acl in db.AccessLevels on us.AccessLevelId equals acl.AccessLevelId
								 select new
								 {
									 Userid = us.UserId,
									 Name = us.LastName + " " + us.FirstName,
									 MName = !string.IsNullOrEmpty(us.MiddleName)? us.MiddleName : string.Empty,
									 gr.GroupName,
									 Al = acl.AccessLevelName
								 };

				
				foreach (var item in stud_group)
				{
					Console.WriteLine($" {item.Userid} {item.Name} {item.MName} {item.GroupName}  {item.Al}");
				}
				Console.WriteLine(new string('-',50));


			}
			//Console.WriteLine("Все сработало, вроде");
			Console.ReadKey();
		}
	}
	public class Person
	{
		public string Name { get; set; }
		public string AccessLevel { get; set; }
	}
}
