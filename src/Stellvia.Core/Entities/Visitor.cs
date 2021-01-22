using System;
using System.Collections.Generic;
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
      /// 用户当前IP
      /// </summary>
      public string Ip { get; set; }

      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;

      /// <summary>
      /// 最后活动时间
      /// </summary>
      public DateTimeOffset LastActivity { get; set; } = DateTimeOffset.Now;
   }
}
