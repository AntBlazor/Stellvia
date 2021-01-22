using System;
using System.Collections.Generic;
using System.Text;

namespace Stellvia.Core.Entities
{
   /// <summary>
   /// 用户第三方登录信息
   /// </summary>
   public class UserConnect
   {
      /// <summary>
      /// 数据ID
      /// </summary>
      public long Id { get; set; }
      /// <summary>
      /// 平台
      /// </summary>
      public int Platform { get; set; }
      /// <summary>
      /// 应用端
      /// </summary>
      public int Client { get; set; }
      /// <summary>
      /// 用户ID
      /// </summary>
      public long UserId { get; set; }
      /// <summary>
      /// 授权OpenId
      /// </summary>
      public long OpenId { get; set; }
      /// <summary>
      /// Unionid
      /// </summary>
      public long UnionId { get; set; }
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;
   }
}
