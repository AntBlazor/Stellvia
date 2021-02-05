using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stellvia.Core.Entities
{
    public class UserStat
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 资金
        /// </summary>
        [Column(TypeName = "decimal(18, 4)")]
        public decimal Money { get; set; }
        /// <summary>
        /// 金币
        /// </summary>
        public int Gold { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int Credits { get; set; }
        /// <summary>
        /// 虚拟币
        /// </summary>
        public int Coin { get; set; }
        /// <summary>
        /// 发帖总数
        /// </summary>
        public int PostCount { get; set; }
        /// <summary>
        /// 回复总数
        /// </summary>
        public int ReplyCount { get; set; }
    }
}
