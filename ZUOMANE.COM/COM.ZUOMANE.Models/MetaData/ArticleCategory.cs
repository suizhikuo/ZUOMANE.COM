using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace COM.ZUOMANE.Models
{
	// The MetadataTypeAttribute identifies TbDealerInfoManageMetadata as the class
	// that carries additional metadata for the TbDealerInfoManage class.
	[MetadataTypeAttribute(typeof(ArticleCategory.ArticleCategoryMetadata))]
	public partial class ArticleCategory
	{
		// This class allows you to attach custom attributes to properties
		// of the TbDealerInfoManage class.
		//
		// For example, the following marks the Xyz property as a
		// required property and specifies the format for valid values:
		//    [Required]
		//    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		//    [StringLength(32)]
		//    public string Xyz { get; set; }
		internal sealed class ArticleCategoryMetadata
		{
			public ArticleCategoryMetadata()
			{
				//this.Articles = new List<Article>();
			}

			[Display(Name = "��ʾ����")]
			public int ID { get; set; }

			[Display(Name = "��ʾ����")]
			public string Name { get; set; }

			[Display(Name = "��ʾ����")]
			public string Description { get; set; }

			[Display(Name = "��ʾ����")]
			public Nullable<int> SortNum { get; set; }

			[Display(Name = "��ʾ����")]
			public Nullable<bool> IsDelete { get; set; }

			[Display(Name = "��ʾ����")]
			public Nullable<int> RecordStatus { get; set; }

			[Display(Name = "��ʾ����")]
			public string CreateUser { get; set; }

			[Display(Name = "��ʾ����")]
			public Nullable<System.DateTime> CreateDatetime { get; set; }

			[Display(Name = "��ʾ����")]
			public string LastUpdateUser { get; set; }

			[Display(Name = "��ʾ����")]
			public Nullable<System.DateTime> LastUpdateDatetime { get; set; }

			//[Display(Name = "��ʾ����")]
			//public virtual ICollection<Article> Articles { get; set; }
		}
	}
}
