using System;
using System.Collections.Generic;
using System.Text;

namespace Stellvia.Core.Entities
{
   /// <summary>
   /// 用户帖子关系
   /// </summary>
   public class UserPost
   {
      /// <summary>
      /// 数据ID
      /// </summary>
      public long Id { get; set; }
      /// <summary>
      /// 用户ID
      /// </summary>
      public long UserId { get; set; }
      /// <summary>
      /// 主题帖子ID
      /// </summary>
      public long PostId { get; set; }
      /// <summary>
      /// 是否已读
      /// </summary>
      public bool Read { get; set; }
      /// <summary>
      /// 是否发布人
      /// </summary>
      public bool Poster { get; set; }
      /// <summary>
      /// 是否被提及
      /// </summary>
      public bool Mentioned { get; set; }
   }
}
