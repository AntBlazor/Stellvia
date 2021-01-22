using System;

namespace Stellvia.Core.Entities
{
   /// <summary>
   /// 用户信息表
   /// </summary>
   public class User
   {
      /// <summary>
      /// 用户ID
      /// </summary>
      public long Id { get; set; }
      /// <summary>
      /// 用户名
      /// </summary>
      public string Username { get; set; }
      /// <summary>
      /// 用户头像
      /// </summary>
      public string Avatar { get; set; }
      /// <summary>
      ///  用户手机
      /// </summary>
      public string Mobile { get; set; }
      /// <summary>
      /// 登录密码
      /// </summary>
      public string Password { get; set; }
      /// <summary>
      /// 资金
      /// </summary>
      public decimal Money { get; set; }
      /// <summary>
      /// 金币
      /// </summary>
      public int Gold { get; set; }
      /// <summary>
      /// 积分
      /// </summary>
      public int Credits { get; set; }
      /// <summary>
      /// 虚拟币
      /// </summary>
      public int Coin { get; set; }
      /// <summary>
      /// 发帖总数
      /// </summary>
      public int PostCount { get; set; }
      /// <summary>
      /// 回复总数
      /// </summary>
      public int ReplyCount { get; set; }
      /// <summary>
      /// 登录次数
      /// </summary>
      public int LoginCount { get; set; }
      /// <summary>
      /// 最后登录时间
      /// </summary>
      public DateTimeOffset LastLogin { get; set; } = DateTimeOffset.Now;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;
   }
}
