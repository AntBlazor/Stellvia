using System;
using System.Collections.Generic;
using System.Text;

namespace Stellvia.Core.Entities
{
   /// <summary>
   /// 标签分类
   /// </summary>
   public class TagCategory
   {
      /// <summary>
      /// 标签ID
      /// </summary>
      public long TagId { get; set; }
      /// <summary>
      /// 分类ID
      /// </summary>
      public long CategoryId { get; set; }
   }
}
