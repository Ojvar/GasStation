using BaseDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
	public class Initializer
	{
		public static void init ()
		{
			ConnectionModel	cm	= new ConnectionModel ()
			{
				dataSource	= ".",
				initCatalog	= "GasStation",
				userId		= "sa",
				password	= "1365"
			};

			BaseDAL.Base.Connection.dataSources.Add (Common.Enum.EDatabase.GasStation.ToString (), cm);
		}
	}
}
