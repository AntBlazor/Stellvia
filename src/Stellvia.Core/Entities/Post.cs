using System;
using System.Collections.Generic;
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
      public string Title { get; set; }
      /// <summary>
      /// 摘要
      /// </summary>
      public string Excerpt { get; set; }
      /// <summary>
      /// 封面图片
      /// </summary>
      public string Image { get; set; }
      /// <summary>
      /// url 缩略名
      /// </summary>
      public string Slug { get; set; }

      /// <summary>
      /// 内容
      /// </summary>
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
      public DateTimeOffset? ModifiedTime { get; set; }

      /// <summary>
      /// 修改次数
      /// </summary>
      public int ModifiedCount { get; set; }

      /// <summary>
      /// 发布时间
      /// </summary>
      public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;

      /// <summary>
      /// 发布ip
      /// </summary>
      public string Ip { get; set; }
   }
}
