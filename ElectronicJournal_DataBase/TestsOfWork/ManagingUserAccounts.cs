using System;
using ElectronicJournal_DataBase.Context;
using ElectronicJournal_DataBase.Model;
using System.Linq;
using System.Collections.ObjectModel;

namespace ElectronicJournal_DataBase.TestsOfWork
{
	public class GeneralUserInformation
	{
		public int UserId { get; set; }
		public string FullName { get; set; }
		public string AccessLevelName { get; set; }
	}

	public class ManagingUserAccounts
	{
		#region Fields

		ObservableCollection<GeneralUserInformation> _usersCollection;

		#endregion

		#region Список пользователей

		//Возвращает список пользователей из бд
		public ObservableCollection<GeneralUserInformation> GetUsersCollection
		{
			get
			{
				if (_usersCollection == null)
					_usersCollection = DataReques();
				return _usersCollection;
			}
		}

		//запрос в бд для формирования списка пользователей
		ObservableCollection<GeneralUserInformation> DataReques()
		{
			ObservableCollection<GeneralUserInformation> userInformation = new ObservableCollection<GeneralUserInformation>();

			using (ElectronicJournalContext db = new ElectronicJournalContext())
			{
				var users = from u in db.Users
							join al in db.AccessLevels on u.AccessLevelId equals al.AccessLevelId
							where al.AccessLevelId <= 3
							select new GeneralUserInformation
							{
								UserId = u.UserId,
								FullName = u.LastName + " " + u.FirstName + " " +
									(!string.IsNullOrEmpty(u.MiddleName) ? u.MiddleName : string.Empty),
								AccessLevelName = al.AccessLevelName
							};
				foreach(var item in users)
				{
					userInformation.Add(item);
				}
			}

			return userInformation;
		}

		#endregion
	}
}
