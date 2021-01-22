using System;
using System.Collections.Generic;
using System.Text;

namespace Stellvia.Core.Entities
{
   /// <summary>
   /// 帖子标签关系
   /// </summary>
   public class PostTags
   {
      /// <summary>
      /// 帖子ID
      /// </summary>
      public long PostId { get; set; }

      /// <summary>
      /// 标签ID
      /// </summary>
      public long TagId { get; set; }
   }
}
