﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.8670
//     Support: http://www.cnblogs.com/huxj
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------


using System;
using System.Data;
using System.Data.Common;
using Dos.ORM;


namespace AhnqIot.Hxj.DbModel
{

	/// <summary>
	/// 实体类Company 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Company : Entity 
	{
		public Company():base("Company") {}

		#region Model
		private string _Serialnum;
		private DateTime _CreateTime;
		private string _CreateSysUserSerialnum;
		private DateTime _UpdateTime;
		private string _UpdateSysUserSerialnum;
		private string _Name;
		private string _Pinyin;
		private string _SysDepartmentSerialnum;
		private string _Addr;
		private string _Lontitude;
		private string _Latitude;
		private string _ContactMan;
		private string _ContactPhone;
		private string _Introduce;
		private int _Status;
		private DateTime? _ApplyTime;
		private int _Sort;
		private string _Remark;
		/// <summary>
		/// 编码
		/// </summary>
		public string Serialnum
		{
			get{ return _Serialnum; }
			set
			{
				this.OnPropertyValueChange(_.Serialnum,_Serialnum,value);
				this._Serialnum=value;
			}
		}
		/// <summary>
		/// 创建时间
		/// </summary>
		public DateTime CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange(_.CreateTime,_CreateTime,value);
				this._CreateTime=value;
			}
		}
		/// <summary>
		/// 创建用户
		/// </summary>
		public string CreateSysUserSerialnum
		{
			get{ return _CreateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.CreateSysUserSerialnum,_CreateSysUserSerialnum,value);
				this._CreateSysUserSerialnum=value;
			}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime UpdateTime
		{
			get{ return _UpdateTime; }
			set
			{
				this.OnPropertyValueChange(_.UpdateTime,_UpdateTime,value);
				this._UpdateTime=value;
			}
		}
		/// <summary>
		/// 更新用户
		/// </summary>
		public string UpdateSysUserSerialnum
		{
			get{ return _UpdateSysUserSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.UpdateSysUserSerialnum,_UpdateSysUserSerialnum,value);
				this._UpdateSysUserSerialnum=value;
			}
		}
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 拼音简写
		/// </summary>
		public string Pinyin
		{
			get{ return _Pinyin; }
			set
			{
				this.OnPropertyValueChange(_.Pinyin,_Pinyin,value);
				this._Pinyin=value;
			}
		}
		/// <summary>
		/// 机构
		/// </summary>
		public string SysDepartmentSerialnum
		{
			get{ return _SysDepartmentSerialnum; }
			set
			{
				this.OnPropertyValueChange(_.SysDepartmentSerialnum,_SysDepartmentSerialnum,value);
				this._SysDepartmentSerialnum=value;
			}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Addr
		{
			get{ return _Addr; }
			set
			{
				this.OnPropertyValueChange(_.Addr,_Addr,value);
				this._Addr=value;
			}
		}
		/// <summary>
		/// 经度
		/// </summary>
		public string Lontitude
		{
			get{ return _Lontitude; }
			set
			{
				this.OnPropertyValueChange(_.Lontitude,_Lontitude,value);
				this._Lontitude=value;
			}
		}
		/// <summary>
		/// 纬度
		/// </summary>
		public string Latitude
		{
			get{ return _Latitude; }
			set
			{
				this.OnPropertyValueChange(_.Latitude,_Latitude,value);
				this._Latitude=value;
			}
		}
		/// <summary>
		/// 联系人
		/// </summary>
		public string ContactMan
		{
			get{ return _ContactMan; }
			set
			{
				this.OnPropertyValueChange(_.ContactMan,_ContactMan,value);
				this._ContactMan=value;
			}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public string ContactPhone
		{
			get{ return _ContactPhone; }
			set
			{
				this.OnPropertyValueChange(_.ContactPhone,_ContactPhone,value);
				this._ContactPhone=value;
			}
		}
		/// <summary>
		/// 介绍
		/// </summary>
		public string Introduce
		{
			get{ return _Introduce; }
			set
			{
				this.OnPropertyValueChange(_.Introduce,_Introduce,value);
				this._Introduce=value;
			}
		}
		/// <summary>
		/// 状态。状态0：禁用1：正在审核中2：审核通过
		/// </summary>
		public int Status
		{
			get{ return _Status; }
			set
			{
				this.OnPropertyValueChange(_.Status,_Status,value);
				this._Status=value;
			}
		}
		/// <summary>
		/// 审核时间
		/// </summary>
		public DateTime? ApplyTime
		{
			get{ return _ApplyTime; }
			set
			{
				this.OnPropertyValueChange(_.ApplyTime,_ApplyTime,value);
				this._ApplyTime=value;
			}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int Sort
		{
			get{ return _Sort; }
			set
			{
				this.OnPropertyValueChange(_.Sort,_Sort,value);
				this._Sort=value;
			}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Remark
		{
			get{ return _Remark; }
			set
			{
				this.OnPropertyValueChange(_.Remark,_Remark,value);
				this._Remark=value;
			}
		}
		#endregion

		#region Method
		/// <summary>
		/// 获取实体中的主键列
		/// </summary>
		public override Field[] GetPrimaryKeyFields()
		{
			return new Field[] {
				_.Serialnum};
		}
		/// <summary>
		/// 获取列信息
		/// </summary>
		public override Field[] GetFields()
		{
			return new Field[] {
				_.Serialnum,
				_.CreateTime,
				_.CreateSysUserSerialnum,
				_.UpdateTime,
				_.UpdateSysUserSerialnum,
				_.Name,
				_.Pinyin,
				_.SysDepartmentSerialnum,
				_.Addr,
				_.Lontitude,
				_.Latitude,
				_.ContactMan,
				_.ContactPhone,
				_.Introduce,
				_.Status,
				_.ApplyTime,
				_.Sort,
				_.Remark};
		}
		/// <summary>
		/// 获取值信息
		/// </summary>
		public override object[] GetValues()
		{
			return new object[] {
				this._Serialnum,
				this._CreateTime,
				this._CreateSysUserSerialnum,
				this._UpdateTime,
				this._UpdateSysUserSerialnum,
				this._Name,
				this._Pinyin,
				this._SysDepartmentSerialnum,
				this._Addr,
				this._Lontitude,
				this._Latitude,
				this._ContactMan,
				this._ContactPhone,
				this._Introduce,
				this._Status,
				this._ApplyTime,
				this._Sort,
				this._Remark};
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(IDataReader reader)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(reader["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(reader["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(reader["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(reader["UpdateSysUserSerialnum"]);
			this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
			this._Pinyin = DataUtils.ConvertValue<string>(reader["Pinyin"]);
			this._SysDepartmentSerialnum = DataUtils.ConvertValue<string>(reader["SysDepartmentSerialnum"]);
			this._Addr = DataUtils.ConvertValue<string>(reader["Addr"]);
			this._Lontitude = DataUtils.ConvertValue<string>(reader["Lontitude"]);
			this._Latitude = DataUtils.ConvertValue<string>(reader["Latitude"]);
			this._ContactMan = DataUtils.ConvertValue<string>(reader["ContactMan"]);
			this._ContactPhone = DataUtils.ConvertValue<string>(reader["ContactPhone"]);
			this._Introduce = DataUtils.ConvertValue<string>(reader["Introduce"]);
			this._Status = DataUtils.ConvertValue<int>(reader["Status"]);
			this._ApplyTime = DataUtils.ConvertValue<DateTime?>(reader["ApplyTime"]);
			this._Sort = DataUtils.ConvertValue<int>(reader["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(reader["Remark"]);
		}
		/// <summary>
		/// 给当前实体赋值
		/// </summary>
		public override void SetPropertyValues(DataRow row)
		{
			this._Serialnum = DataUtils.ConvertValue<string>(row["Serialnum"]);
			this._CreateTime = DataUtils.ConvertValue<DateTime>(row["CreateTime"]);
			this._CreateSysUserSerialnum = DataUtils.ConvertValue<string>(row["CreateSysUserSerialnum"]);
			this._UpdateTime = DataUtils.ConvertValue<DateTime>(row["UpdateTime"]);
			this._UpdateSysUserSerialnum = DataUtils.ConvertValue<string>(row["UpdateSysUserSerialnum"]);
			this._Name = DataUtils.ConvertValue<string>(row["Name"]);
			this._Pinyin = DataUtils.ConvertValue<string>(row["Pinyin"]);
			this._SysDepartmentSerialnum = DataUtils.ConvertValue<string>(row["SysDepartmentSerialnum"]);
			this._Addr = DataUtils.ConvertValue<string>(row["Addr"]);
			this._Lontitude = DataUtils.ConvertValue<string>(row["Lontitude"]);
			this._Latitude = DataUtils.ConvertValue<string>(row["Latitude"]);
			this._ContactMan = DataUtils.ConvertValue<string>(row["ContactMan"]);
			this._ContactPhone = DataUtils.ConvertValue<string>(row["ContactPhone"]);
			this._Introduce = DataUtils.ConvertValue<string>(row["Introduce"]);
			this._Status = DataUtils.ConvertValue<int>(row["Status"]);
			this._ApplyTime = DataUtils.ConvertValue<DateTime?>(row["ApplyTime"]);
			this._Sort = DataUtils.ConvertValue<int>(row["Sort"]);
			this._Remark = DataUtils.ConvertValue<string>(row["Remark"]);
		}
		#endregion

		#region _Field
		/// <summary>
		/// 字段信息
		/// </summary>
		public class _
		{
			/// <summary>
			/// * 
			/// </summary>
			public readonly static Field All = new Field("*","Company");
			/// <summary>
			/// 编码
			/// </summary>
			public readonly static Field Serialnum = new Field("Serialnum","Company","编码");
			/// <summary>
			/// 创建时间
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","Company","创建时间");
			/// <summary>
			/// 创建用户
			/// </summary>
			public readonly static Field CreateSysUserSerialnum = new Field("CreateSysUserSerialnum","Company","创建用户");
			/// <summary>
			/// 更新时间
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","Company","更新时间");
			/// <summary>
			/// 更新用户
			/// </summary>
			public readonly static Field UpdateSysUserSerialnum = new Field("UpdateSysUserSerialnum","Company","更新用户");
			/// <summary>
			/// 名称
			/// </summary>
			public readonly static Field Name = new Field("Name","Company","名称");
			/// <summary>
			/// 拼音简写
			/// </summary>
			public readonly static Field Pinyin = new Field("Pinyin","Company","拼音简写");
			/// <summary>
			/// 机构
			/// </summary>
			public readonly static Field SysDepartmentSerialnum = new Field("SysDepartmentSerialnum","Company","机构");
			/// <summary>
			/// 地址
			/// </summary>
			public readonly static Field Addr = new Field("Addr","Company","地址");
			/// <summary>
			/// 经度
			/// </summary>
			public readonly static Field Lontitude = new Field("Lontitude","Company","经度");
			/// <summary>
			/// 纬度
			/// </summary>
			public readonly static Field Latitude = new Field("Latitude","Company","纬度");
			/// <summary>
			/// 联系人
			/// </summary>
			public readonly static Field ContactMan = new Field("ContactMan","Company","联系人");
			/// <summary>
			/// 联系电话
			/// </summary>
			public readonly static Field ContactPhone = new Field("ContactPhone","Company","联系电话");
			/// <summary>
			/// 介绍
			/// </summary>
			public readonly static Field Introduce = new Field("Introduce","Company","介绍");
			/// <summary>
			/// 状态。状态0：禁用1：正在审核中2：审核通过
			/// </summary>
			public readonly static Field Status = new Field("Status","Company","状态。状态0：禁用1：正在审核中2：审核通过");
			/// <summary>
			/// 审核时间
			/// </summary>
			public readonly static Field ApplyTime = new Field("ApplyTime","Company","审核时间");
			/// <summary>
			/// 排序
			/// </summary>
			public readonly static Field Sort = new Field("Sort","Company","排序");
			/// <summary>
			/// 备注
			/// </summary>
			public readonly static Field Remark = new Field("Remark","Company","备注");
		}
		#endregion


	}
}

