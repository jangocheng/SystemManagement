﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemManagement.Entity
{
	/// <summary>
	/// 账号
	/// </summary>
	[Table("SysUser")]
	[Description("账号")]
	public class SysUser
	{
		/// <summary>
		/// 账户
		/// </summary>
		[Description("账户")]
		[StringLength(32)]
		[Column("Account")]
		public string Account { get; set; }

		[StringLength(255)]
		[Column("Avatar")]
		public string Avatar { get; set; }

		[Column("Birthday")]
		public DateTime? Birthday { get; set; }

		/// <summary>
		/// 创建人
		/// </summary>
		[Description("创建人")]
		[Column("CreateBy")]
		public long? CreateBy { get; set; }

		/// <summary>
		/// 创建时间/注册时间
		/// </summary>
		[Description("创建时间/注册时间")]
		[Column("CreateTime")]
		public DateTime? CreateTime { get; set; }

		[Column("DeptId")]
		public long? DeptId { get; set; }

		/// <summary>
		/// email
		/// </summary>
		[Description("email")]
		[StringLength(64)]
		[Column("Email")]
		public string Email { get; set; }

		[Key]
		[Column("ID")]
		public long ID { get; set; }

		/// <summary>
		/// 最后更新人
		/// </summary>
		[Description("最后更新人")]
		[Column("ModifyBy")]
		public long? ModifyBy { get; set; }

		/// <summary>
		/// 最后更新时间
		/// </summary>
		[Description("最后更新时间")]
		[Column("ModifyTime")]
		public DateTime? ModifyTime { get; set; }

		/// <summary>
		/// 姓名
		/// </summary>
		[Description("姓名")]
		[StringLength(64)]
		[Column("Name")]
		public string Name { get; set; }

		/// <summary>
		/// 密码
		/// </summary>
		[Description("密码")]
		[StringLength(64)]
		[Column("Password")]
		public string Password { get; set; }

		/// <summary>
		/// 手机号
		/// </summary>
		[Description("手机号")]
		[StringLength(16)]
		[Column("Phone")]
		public string Phone { get; set; }

		/// <summary>
		/// 角色id列表，以逗号分隔
		/// </summary>
		[Description("角色id列表，以逗号分隔")]
		[StringLength(128)]
		[Column("RoleId")]
		public string RoleId { get; set; }

		/// <summary>
		/// 密码盐
		/// </summary>
		[Description("密码盐")]
		[StringLength(16)]
		[Column("Salt")]
		public string Salt { get; set; }

		[Column("Sex")]
		public int Sex { get; set; }

		[Column("Status")]
		public bool Status { get; set; }

		[Column("Version")]
		public int? Version { get; set; }
	}
}
