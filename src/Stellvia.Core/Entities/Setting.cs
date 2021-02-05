using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stellvia.Core.Entities
{

    /// <summary>
    /// 系统设置
    /// </summary>
    public class Setting
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 设置对象名
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; }
        /// <summary>
        /// 设置内容
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Value { get; set; }
    }
}
