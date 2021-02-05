using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Stellvia.Core.Entities
{
    /// <summary>
    /// 存储内容，包括话题、文章、页面等
    /// </summary>
    public class Post
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 分类ID
        /// </summary>
        public long CategoryId { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        [Column(TypeName = "nvarchar(256)")]
        public string Excerpt { get; set; }
        /// <summary>
        /// 封面图片
        /// </summary>
        [Column(TypeName = "varchar(256)")]
        public string Image { get; set; }
        /// <summary>
        /// url 缩略名
        /// </summary>
        [Column(TypeName = "varchar(100)")]
        public string Slug { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [Column(TypeName = "nvarchar(max)")]
        public string Content { get; set; }

        /// <summary>
        /// 作者ID
        /// </summary>
        public long UserId { get; set; }

        /// <summary>
        /// 回复评论数量
        /// </summary>
        public int ReplyCount { get; set; }

        /// <summary>
        /// 回复评论数量，控制是否可以回复评论
        /// </summary>
        public int ReplyStatus { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedTime { get; set; }

        /// <summary>
        /// 修改次数
        /// </summary>
        public int ModifiedCount { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 阅读数量
        /// </summary>
        public int ViewCount { get; set; }

        /// <summary>
        /// 支持的
        /// </summary>
        public int Supported { get; set; }

        /// <summary>
        /// 反对的，无意义的，不支持的
        /// </summary>
        public int Opposed { get; set; }

        /// <summary>
        /// 发布ip
        /// </summary>
        [Column(TypeName = "varchar(50)")]
        public string Ip { get; set; }
    }
}
