using System;
using System.Data;
using BaseDAL.Model;

namespace Common.BLL.Entity.GasStation
{
	[Serializable]
	public class Car : BaseBLL.Entity.BaseByViewId
	{


		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.Int,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,foreignLogicType=typeof (BLL.Logic.GasStation.Base__CarType),foreignField="id")]
		public System.Int32 carTypeId
		{
			get;
			set;
		}
//
	// Genereted Property of carTypeId
	//
	#region Referenced Property - Base__CarType
		BLL.Entity.GasStation.Base__CarType _Base__CarType_carTypeId;
		public BLL.Entity.GasStation.Base__CarType Base__CarType_carTypeId
		{
			get
			{
				if ((null == _Base__CarType_carTypeId) && (AutoLoadForeignKeys))
					load_Base__CarType_carTypeId ();
				return _Base__CarType_carTypeId;
			}
			set
			{
				_Base__CarType_carTypeId	= value;
			}
		}

		public void load_Base__CarType_carTypeId ()
		{ 
			BLL.Entity.GasStation.Base__CarType	entity;
			BLL.Logic.GasStation.Base__CarType	logic;

			entity	= new BLL.Entity.GasStation.Base__CarType () { id = carTypeId };
			logic	= new BLL.Logic.GasStation.Base__CarType (Common.Enum.EDatabase.GasStation);
			logic.read (entity);

			_Base__CarType_carTypeId	= entity;
		}
	#endregion

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.SmallInt,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create)]
		public System.Int16 capacity
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String chasisCode
		{
			get;
			set;
		}

		[BaseBLL.Base.Field(nullable=false,sqlDBType=System.Data.SqlDbType.VarChar,primary=false,usage=BaseBLL.Base.EnumUsage.read | BaseBLL.Base.EnumUsage.update | BaseBLL.Base.EnumUsage.create,size=50)]
		public System.String engineCode
		{
			get;
			set;
		}
	}
}