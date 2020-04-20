using System.Collections.Generic;
using ElectronicJournal_DataBase.Model;

namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_Building
	{
		private List<Building> _buildings = new List<Building>();
		public Initialization_Building()
		{
			Building b1 = new Building()
			{
				BuildingId = 1,
				BuildingName = "Оршанская"
			};
			Building b2 = new Building()
			{
				BuildingId = 2,
				BuildingName = "ИНЖЭКИН"
			};
			_buildings.Add(b1);
			_buildings.Add(b2);
		}
		public List<Building> Initialization
		{
			get { return _buildings; }
		}
	}
}
