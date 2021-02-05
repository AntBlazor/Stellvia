using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stellvia.Core.Entities
{
    /// <summary>
    /// 在线访客记录
    /// </summary>
    public class Visitor
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 用户ID，游客0
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [Column(TypeName = "nvarchar(30)")]
        public string Username { get; set; }

        /// <summary>
        /// 用户当前IP
        /// </summary>
        [Column(TypeName = "nvarchar(50)")]
        public string Ip { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 最后活动时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime LastActivity { get; set; } = DateTime.Now;
    }
}
