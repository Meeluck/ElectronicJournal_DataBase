using System.Collections.Generic;
using ElectronicJournal_Library;
using ElectronicJournal_DataBase.Model;
namespace ElectronicJournal_DataBase.Context.InitializationData
{
	public class Initialization_Position
	{
		private List<Position> _positions = new List<Position>();
		public Initialization_Position()
		{
			Position ps1 = new Position()
			{
				PositionId = 1,
				PositionName = "Лаборант"
			};
			Position ps2 = new Position()
			{
				PositionId = 2,
				PositionName = "Преподаватель"
			};
			Position ps3 = new Position()
			{
				PositionId = 3,
				PositionName = "Старший преподаватель"
			};
			Position ps4 = new Position()
			{
				PositionId = 4,
				PositionName = "Доцент"
			};
			Position ps5 = new Position()
			{
				PositionId = 5,
				PositionName = "Профессор"
			};

			_positions.Add(ps1);
			_positions.Add(ps2);
			_positions.Add(ps3);
			_positions.Add(ps4);
			_positions.Add(ps5);

		}
		
		public List<Position> Initialization
		{
			get { return _positions; }
		}
	}
}
