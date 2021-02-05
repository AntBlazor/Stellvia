using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stellvia.Core.Entities
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class User
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Column(TypeName = "nvarchar(30)")]
        public string Username { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        [Column(TypeName = "varchar(256)")]
        public string Avatar { get; set; }
        /// <summary>
        ///  用户手机
        /// </summary>
        [Column(TypeName = "varchar(12)")]
        public string Mobile { get; set; }
        /// <summary>
        /// 登录密码
        /// </summary>
        [Column(TypeName = "varchar(32)")]
        public string Password { get; set; }

        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginCount { get; set; }

        /// <summary>
        /// 最后登录时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime LastLogin { get; set; } = DateTime.Now;

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
