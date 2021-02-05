using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stellvia.Core.Entities
{
    /// <summary>
    /// 标签
    /// </summary>
    public class Tag
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; } = DateTime.Now;
    }
}
