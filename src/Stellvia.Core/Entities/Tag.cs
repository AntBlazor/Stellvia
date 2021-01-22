using System;
using System.Collections.Generic;
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
      public string Name { get; set; }
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;
   }
}
