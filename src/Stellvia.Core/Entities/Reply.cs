using System;
using System.Collections.Generic;
using System.Text;

namespace Stellvia.Core.Entities
{
   /// <summary>
   /// 回复内容，用于回帖，评论，答案
   /// </summary>
   public class Reply
   {
      /// <summary>
      /// 数据ID
      /// </summary>
      public long Id { get; set; }

      /// <summary>
      /// 主题内容ID
      /// </summary>
      public long PostId { get; set; }

      /// <summary>
      /// 发布用户
      /// </summary>
      public long UserId { get; set; }

      /// <summary>
      /// 父回复内容ID
      /// </summary>
      public long ParentId { get; set; }

      /// <summary>
      /// 内容
      /// </summary>
      public string Content { get; set; }

      /// <summary>
      /// 子评论
      /// </summary>
      public string Comments { get; set; }

      /// <summary>
      /// 发布ip
      /// </summary>
      public string Ip { get; set; }

      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;


   }
}
