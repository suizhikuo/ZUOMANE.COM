//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplicationTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Article
    {
        public int ID { get; set; }
        public int ArticleCategoryID { get; set; }
        public string ArticleContent { get; set; }
        public Nullable<int> SortNum { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<int> RecordStatus { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDatetime { get; set; }
        public string LastUpdateUser { get; set; }
        public Nullable<System.DateTime> LastUpdateDatetime { get; set; }
    
        public virtual ArticleCategory ArticleCategory { get; set; }
    }
}
