using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stellvia.Core.Entities
{
    /// <summary>
    /// 统计信息
    /// </summary>
    public class Statistic
    {
        /// <summary>
        /// 日期ID，0则是全局统计
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 用户总数
        /// </summary>
        public int UserCount { get; set; }
        /// <summary>
        /// 帖子总数
        /// </summary>
        public int PostCount { get; set; }
        /// <summary>
        /// 回帖总数
        /// </summary>
        public int ReplyCount { get; set; }

        /// <summary>
        /// 最高在线人数
        /// </summary>
        public int MaxOnlineCount { get; set; }

        /// <summary>
        /// 最高在线人数时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime MaxOnlineTime { get; set; } = DateTime.Now;
    }
}
