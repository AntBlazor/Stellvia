using System;
using System.Collections.Generic;
using System.Text;

namespace Stellvia.Core.Entities
{
   /// <summary>
   /// 分类，可扩展用于社区内容分类，文章分类，产品分类等
   /// </summary>
   public class Category
   {
      /// <summary>
      /// 数据ID
      /// </summary>
      public long Id { get; set; }

      /// <summary>
      /// 分类类型
      /// </summary>
      public int Type { get; set; }

      /// <summary>
      /// 父级分类ID
      /// </summary>
      public long ParentId { get; set; }

      /// <summary>
      /// 分类名称
      /// </summary>
      public string Name { get; set; }

      /// <summary>
      /// url seo 缩略名
      /// </summary>
      public string Slug { get; set; }

      /// <summary>
      /// 分类封面图片
      /// </summary>
      public string Image { get; set; }

      /// <summary>
      /// 介绍描述
      /// </summary>
      public string Description { get; set; }

      /// <summary>
      /// 标识是否仅作为节点
      /// </summary>
      public bool IsNode { get; set; }

      /// <summary>
      /// 是否已启用
      /// </summary>
      public bool Enabled { get; set; }

      /// <summary>
      /// 层级路径
      /// </summary>
      public string Path { get; set; }

      /// <summary>
      /// 层级深度
      /// </summary>
      public int Depth { get; set; }

      /// <summary>
      /// 数据统计总数量
      /// </summary>
      public int Total { get; set; }

      /// <summary>
      /// 展示排序
      /// </summary>
      public int DisplayOrder { get; set; }

      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTimeOffset CreateTime { get; set; } = DateTimeOffset.Now;

      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTimeOffset UpdateTime { get; set; } = DateTimeOffset.Now;
   }
}
