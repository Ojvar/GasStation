using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Base__CarType : BaseBLL.Entity.BaseByViewId
	{
	//
	// Genereted Property of Car
	//
	#region Relation - Car (Has-Many relation)
		private System.Data.DataTable _get_Car_carTypeId;
		public System.Data.DataTable getCar_carTypeId
		{
			get
			{
				if ((_get_Car_carTypeId == null) && (AutoLoadForeignKeys))
					loadCar_carTypeId ();

				return _get_Car_carTypeId;
			}
			set
			{
				_get_Car_carTypeId	= value;
			}
		}

		public void loadCar_carTypeId (int pageIndex = -1, int pageSize = 100)
		{
			CommandResult	opResult;

			BLL.Logic.GasStation.Car	logic	= new BLL.Logic.GasStation.Car (Common.Enum.EDatabase.GasStation);
			if (pageIndex == -1)
				opResult	= logic.allData ("carTypeId = @carTypeId", "", false, true, new KeyValuePair ("@carTypeId", id));
			else
				opResult	= logic.allByPaging ( pageIndex, pageSize, "carTypeId = @carTypeId", "", false, true, new KeyValuePair ("@carTypeId", id));

			if (opResult.status == BaseDAL.Base.EnumCommandStatus.success)
				_get_Car_carTypeId	= opResult.model as System.Data.DataTable;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String type
		{
			get;
			set;
		}
	}
}