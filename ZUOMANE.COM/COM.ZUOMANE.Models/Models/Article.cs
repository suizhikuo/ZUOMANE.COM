using System;
using System.Collections.Generic;

namespace COM.ZUOMANE.Models
{
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
